namespace Primera_Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelsubConsultas = new System.Windows.Forms.Panel();
            this.btnCbalancePendiente = new System.Windows.Forms.Button();
            this.btnCpagos = new System.Windows.Forms.Button();
            this.btnCprestamos = new System.Windows.Forms.Button();
            this.btnCclientes = new System.Windows.Forms.Button();
            this.panelsubservicios = new System.Windows.Forms.Panel();
            this.btnprestamos = new System.Windows.Forms.Button();
            this.Prestamos = new System.Windows.Forms.Button();
            this.panelsubclientes = new System.Windows.Forms.Panel();
            this.btnvercliente = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnconsultas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.panelsubConsultas.SuspendLayout();
            this.panelsubservicios.SuspendLayout();
            this.panelsubclientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 213);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(71, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(150, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 100);
            this.panel2.TabIndex = 4;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoScroll = true;
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelPrincipal.Controls.Add(this.panelsubConsultas);
            this.panelPrincipal.Controls.Add(this.btnconsultas);
            this.panelPrincipal.Controls.Add(this.panelsubservicios);
            this.panelPrincipal.Controls.Add(this.Prestamos);
            this.panelPrincipal.Controls.Add(this.panelsubclientes);
            this.panelPrincipal.Controls.Add(this.btnclientes);
            this.panelPrincipal.Controls.Add(this.panelLogo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.ForeColor = System.Drawing.Color.White;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(150, 313);
            this.panelPrincipal.TabIndex = 3;
            // 
            // panelsubConsultas
            // 
            this.panelsubConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelsubConsultas.Controls.Add(this.btnCbalancePendiente);
            this.panelsubConsultas.Controls.Add(this.btnCpagos);
            this.panelsubConsultas.Controls.Add(this.btnCprestamos);
            this.panelsubConsultas.Controls.Add(this.btnCclientes);
            this.panelsubConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubConsultas.Location = new System.Drawing.Point(0, 124);
            this.panelsubConsultas.Name = "panelsubConsultas";
            this.panelsubConsultas.Size = new System.Drawing.Size(150, 94);
            this.panelsubConsultas.TabIndex = 6;
       
            // 
            // btnCbalancePendiente
            // 
            this.btnCbalancePendiente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCbalancePendiente.FlatAppearance.BorderSize = 0;
            this.btnCbalancePendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCbalancePendiente.ForeColor = System.Drawing.Color.LightGray;
            this.btnCbalancePendiente.Location = new System.Drawing.Point(0, 65);
            this.btnCbalancePendiente.Name = "btnCbalancePendiente";
            this.btnCbalancePendiente.Size = new System.Drawing.Size(150, 21);
            this.btnCbalancePendiente.TabIndex = 6;
            this.btnCbalancePendiente.Text = "Balance Pendiente";
            this.btnCbalancePendiente.UseVisualStyleBackColor = true;
            this.btnCbalancePendiente.Click += new System.EventHandler(this.btnCbalancePendiente_Click);
            // 
            // btnCpagos
            // 
            this.btnCpagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCpagos.FlatAppearance.BorderSize = 0;
            this.btnCpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCpagos.ForeColor = System.Drawing.Color.LightGray;
            this.btnCpagos.Location = new System.Drawing.Point(0, 44);
            this.btnCpagos.Name = "btnCpagos";
            this.btnCpagos.Size = new System.Drawing.Size(150, 21);
            this.btnCpagos.TabIndex = 5;
            this.btnCpagos.Text = "Pagos";
            this.btnCpagos.UseVisualStyleBackColor = true;
            this.btnCpagos.Click += new System.EventHandler(this.btnCpagos_Click);
            // 
            // btnCprestamos
            // 
            this.btnCprestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCprestamos.FlatAppearance.BorderSize = 0;
            this.btnCprestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCprestamos.ForeColor = System.Drawing.Color.LightGray;
            this.btnCprestamos.Location = new System.Drawing.Point(0, 23);
            this.btnCprestamos.Name = "btnCprestamos";
            this.btnCprestamos.Size = new System.Drawing.Size(150, 21);
            this.btnCprestamos.TabIndex = 4;
            this.btnCprestamos.Text = "Prestamos";
            this.btnCprestamos.UseVisualStyleBackColor = true;
            this.btnCprestamos.Click += new System.EventHandler(this.btnCprestamos_Click);
            // 
            // btnCclientes
            // 
            this.btnCclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCclientes.FlatAppearance.BorderSize = 0;
            this.btnCclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCclientes.ForeColor = System.Drawing.Color.LightGray;
            this.btnCclientes.Location = new System.Drawing.Point(0, 0);
            this.btnCclientes.Name = "btnCclientes";
            this.btnCclientes.Size = new System.Drawing.Size(150, 23);
            this.btnCclientes.TabIndex = 2;
            this.btnCclientes.Text = "Clientes";
            this.btnCclientes.UseVisualStyleBackColor = true;
            this.btnCclientes.Click += new System.EventHandler(this.btnCclientes_Click);
            // 
            // panelsubservicios
            // 
            this.panelsubservicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelsubservicios.Controls.Add(this.btnprestamos);
            this.panelsubservicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubservicios.Location = new System.Drawing.Point(0, 78);
            this.panelsubservicios.Name = "panelsubservicios";
            this.panelsubservicios.Size = new System.Drawing.Size(150, 23);
            this.panelsubservicios.TabIndex = 4;
            // 
            // btnprestamos
            // 
            this.btnprestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnprestamos.FlatAppearance.BorderSize = 0;
            this.btnprestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprestamos.ForeColor = System.Drawing.Color.LightGray;
            this.btnprestamos.Location = new System.Drawing.Point(0, 0);
            this.btnprestamos.Name = "btnprestamos";
            this.btnprestamos.Size = new System.Drawing.Size(150, 23);
            this.btnprestamos.TabIndex = 2;
            this.btnprestamos.Text = "Prestamos";
            this.btnprestamos.UseVisualStyleBackColor = true;
            this.btnprestamos.Click += new System.EventHandler(this.btnprestamos_Click);
            // 
            // Prestamos
            // 
            this.Prestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Prestamos.FlatAppearance.BorderSize = 0;
            this.Prestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prestamos.ForeColor = System.Drawing.Color.Gainsboro;
            this.Prestamos.Location = new System.Drawing.Point(0, 49);
            this.Prestamos.Name = "Prestamos";
            this.Prestamos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Prestamos.Size = new System.Drawing.Size(150, 29);
            this.Prestamos.TabIndex = 3;
            this.Prestamos.Text = "Servicios";
            this.Prestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Prestamos.UseVisualStyleBackColor = true;
            this.Prestamos.Click += new System.EventHandler(this.Prestamos_Click);
            // 
            // panelsubclientes
            // 
            this.panelsubclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelsubclientes.Controls.Add(this.btnvercliente);
            this.panelsubclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubclientes.Location = new System.Drawing.Point(0, 23);
            this.panelsubclientes.Name = "panelsubclientes";
            this.panelsubclientes.Size = new System.Drawing.Size(150, 26);
            this.panelsubclientes.TabIndex = 2;
            // 
            // btnvercliente
            // 
            this.btnvercliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvercliente.FlatAppearance.BorderSize = 0;
            this.btnvercliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvercliente.ForeColor = System.Drawing.Color.LightGray;
            this.btnvercliente.Location = new System.Drawing.Point(0, 0);
            this.btnvercliente.Name = "btnvercliente";
            this.btnvercliente.Size = new System.Drawing.Size(150, 23);
            this.btnvercliente.TabIndex = 2;
            this.btnvercliente.Text = "Ver clientes";
            this.btnvercliente.UseVisualStyleBackColor = true;
            this.btnvercliente.Click += new System.EventHandler(this.btnvercliente_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnclientes.Location = new System.Drawing.Point(0, 0);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnclientes.Size = new System.Drawing.Size(150, 23);
            this.btnclientes.TabIndex = 1;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Location = new System.Drawing.Point(0, -32);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(133, 87);
            this.panelLogo.TabIndex = 0;
            // 
            // btnconsultas
            // 
            this.btnconsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconsultas.FlatAppearance.BorderSize = 0;
            this.btnconsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnconsultas.Location = new System.Drawing.Point(0, 101);
            this.btnconsultas.Name = "btnconsultas";
            this.btnconsultas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnconsultas.Size = new System.Drawing.Size(150, 23);
            this.btnconsultas.TabIndex = 5;
            this.btnconsultas.Text = "Consultas";
            this.btnconsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultas.UseVisualStyleBackColor = true;
            this.btnconsultas.Click += new System.EventHandler(this.btnconsultas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 313);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelsubConsultas.ResumeLayout(false);
            this.panelsubservicios.ResumeLayout(false);
            this.panelsubclientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelsubConsultas;
        private System.Windows.Forms.Button btnCbalancePendiente;
        private System.Windows.Forms.Button btnCpagos;
        private System.Windows.Forms.Button btnCprestamos;
        private System.Windows.Forms.Button btnCclientes;
        private System.Windows.Forms.Panel panelsubservicios;
        private System.Windows.Forms.Button btnprestamos;
        private System.Windows.Forms.Button Prestamos;
        private System.Windows.Forms.Panel panelsubclientes;
        private System.Windows.Forms.Button btnvercliente;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnconsultas;
    }
}

