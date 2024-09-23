﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            // Verifica si Tdni está vacío
            if (string.IsNullOrWhiteSpace(Tdni.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Verifica si Tdni contiene solo números
            if (!long.TryParse(Tdni.Text, out _)) // Intenta convertir a número
            {
                MessageBox.Show("El campo DNI solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Verifica si Tpassword está vacío
            if (string.IsNullOrWhiteSpace(Tpassword.Text))
            {
                MessageBox.Show("El campo Contraseña no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
           
            Inicio form = new Inicio();
            form.Show();
            this.Hide();
       
            form.FormClosing += frm_closing;
        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {


            this.Show();
        }











































    }    
}
