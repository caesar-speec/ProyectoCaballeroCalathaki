using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmBackup : Form
    {
        // La carpeta de *defecto*
        private string defaultBackupFolder = @"C:\Users\Usuario\source\repos\ProyectoCaballeroCalathaki\Backups_SQL";

        // Variables para la conexión
        private string appConnectionString;
        private string masterConnectionString;
        private string databaseName;

        public frmBackup()
        {
            InitializeComponent();
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener la cadena de conexión de tu capa de datos
                appConnectionString = Conexion.cadena;

                // 2. Extraer el nombre de la base de datos (Ej: "DBProyecto")
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(appConnectionString);
                databaseName = builder.InitialCatalog;

                // 3. Crear una cadena de conexión a la base de datos "master"
                SqlConnectionStringBuilder masterBuilder = new SqlConnectionStringBuilder(appConnectionString);
                masterBuilder.InitialCatalog = "master";
                masterConnectionString = masterBuilder.ConnectionString;

                // 4. Configurar los campos del formulario
                txtBackupPath.Text = defaultBackupFolder; // Establece la ruta por defecto
                ActualizarNombreBackup();

                // 5. Cargar backups (esto disparará txtBackupPath_TextChanged y cargará el combo)
                // (No es necesario llamar a CargarBackupsExistentes() aquí, 
                //  ya que el evento TextChanged lo hará)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el formulario de Backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Genera un nuevo nombre de archivo para el próximo backup
        private void ActualizarNombreBackup()
        {
            txtBackupName.Text = $"{databaseName}_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
        }

        // Lee la carpeta y lista todos los archivos .bak en el ComboBox
        private void CargarBackupsExistentes()
        {
            string currentPath = txtBackupPath.Text; // Lee la ruta actual
            cboBackups.Items.Clear();

            // Comprueba si la carpeta (nueva o por defecto) existe
            if (Directory.Exists(currentPath))
            {
                string[] backupFiles = Directory.GetFiles(currentPath, "*.bak");
                if (backupFiles.Length > 0)
                {
                    // Ordena por fecha de modificación (el más nuevo primero)
                    var orderedFiles = backupFiles
                        .Select(f => new FileInfo(f))
                        .OrderByDescending(f => f.LastWriteTime)
                        .Select(f => f.Name)
                        .ToArray();

                    cboBackups.Items.AddRange(orderedFiles);
                    cboBackups.SelectedIndex = 0;
                }
                else
                {
                    cboBackups.Text = "No se encontraron backups";
                }
            }
            else
            {
                cboBackups.Text = "La carpeta seleccionada no existe";
            }
        }

        private void btnCrearBackup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea crear una nueva copia de seguridad?", "Confirmar Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string currentPath = txtBackupPath.Text; // Lee la ruta del TextBox

            // Asegurarse de que la carpeta de backup exista
            if (!Directory.Exists(currentPath))
            {
                try
                {
                    Directory.CreateDirectory(currentPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear la carpeta de destino: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string fullPath = Path.Combine(currentPath, txtBackupName.Text);

            if (File.Exists(fullPath))
            {
                MessageBox.Show("Un archivo con este nombre ya existe. Se generará un nuevo nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActualizarNombreBackup();
                fullPath = Path.Combine(currentPath, txtBackupName.Text);
            }

            progressBar.Visible = true;

            try
            {
                using (SqlConnection con = new SqlConnection(masterConnectionString))
                {
                    con.Open();
                    string backupQuery = $"BACKUP DATABASE [{databaseName}] TO DISK = '{fullPath}' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of {databaseName}';";

                    using (SqlCommand cmd = new SqlCommand(backupQuery, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Copia de seguridad creada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarBackupsExistentes();
                ActualizarNombreBackup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Visible = false;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (cboBackups.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un archivo de backup para restaurar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¡ADVERTENCIA!\n\nRestaurar una base de datos sobrescribirá TODOS los datos actuales.\nEsta acción desconectará a todos los usuarios.\n\n¿Está SEGURO de que desea continuar?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            if (MessageBox.Show("¡ÚLTIMA ADVERTENCIA!\n\nSe perderán todos los cambios realizados después de la fecha del backup seleccionado.\n\n¿Proceder con la restauración?", "Confirmación Final", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
            {
                return;
            }

            string backupFile = cboBackups.SelectedItem.ToString();
            string currentPath = txtBackupPath.Text; // Lee la ruta del TextBox
            string fullPath = Path.Combine(currentPath, backupFile);

            progressBar.Visible = true;

            try
            {
                using (SqlConnection con = new SqlConnection(masterConnectionString))
                {
                    con.Open();

                    string singleUserQuery = $"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    using (SqlCommand cmd = new SqlCommand(singleUserQuery, con))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    string restoreQuery = $"RESTORE DATABASE [{databaseName}] FROM DISK = '{fullPath}' WITH REPLACE;";
                    using (SqlCommand cmd = new SqlCommand(restoreQuery, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Restauración completada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(masterConnectionString))
                    {
                        con.Open();
                        string multiUserQuery = $"ALTER DATABASE [{databaseName}] SET MULTI_USER;";
                        using (SqlCommand cmd = new SqlCommand(multiUserQuery, con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡ERROR CRÍTICO! No se pudo volver a poner la base de datos en modo multi-usuario. Cierre la aplicación y contacte al administrador.\n\n" + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                progressBar.Visible = false;
            }
        }

        // *** NUEVO EVENTO ***
        // Se dispara al hacer clic en el botón "..."
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Usa el folderBrowserDialog que agregamos en el Designer
            folderBrowserDialog.Description = "Seleccione la carpeta para guardar los backups";
            folderBrowserDialog.SelectedPath = txtBackupPath.Text; // Inicia en la carpeta actual

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Actualiza el TextBox con la nueva ruta
                txtBackupPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        // *** NUEVO EVENTO ***
        // Se dispara cada vez que el texto de la ruta cambia
        private void txtBackupPath_TextChanged(object sender, EventArgs e)
        {
            // Actualiza la lista de backups para la nueva carpeta
            CargarBackupsExistentes();
        }


        // Eventos vacíos de tu designer original
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}