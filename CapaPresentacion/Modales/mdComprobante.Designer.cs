namespace CapaPresentacion.Modales
{
    partial class mdComprobante
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            webBrowser1 = new WebBrowser();
            btnimprimir = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // webBrowser1
            // 
            webBrowser1.Location = new Point(12, 15);
            webBrowser1.Margin = new Padding(3, 4, 3, 4);
            webBrowser1.MinimumSize = new Size(20, 25);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new Size(776, 688);
            webBrowser1.TabIndex = 0;
            // 
            // btnimprimir
            // 
            btnimprimir.BackColor = Color.CornflowerBlue;
            btnimprimir.Cursor = Cursors.Hand;
            btnimprimir.FlatStyle = FlatStyle.Flat;
            btnimprimir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnimprimir.ForeColor = Color.White;
            btnimprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnimprimir.IconColor = Color.White;
            btnimprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnimprimir.IconSize = 20;
            btnimprimir.Location = new Point(12, 710);
            btnimprimir.Margin = new Padding(3, 4, 3, 4);
            btnimprimir.Name = "btnimprimir";
            btnimprimir.Size = new Size(144, 51);
            btnimprimir.TabIndex = 1;
            btnimprimir.Text = "Imprimir";
            btnimprimir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnimprimir.UseVisualStyleBackColor = false;
            btnimprimir.Click += btnimprimir_Click;
            // 
            // mdComprobante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 776);
            Controls.Add(btnimprimir);
            Controls.Add(webBrowser1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mdComprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Impresión de Comprobante";
            Load += mdComprobante_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private FontAwesome.Sharp.IconButton btnimprimir;
    }
}