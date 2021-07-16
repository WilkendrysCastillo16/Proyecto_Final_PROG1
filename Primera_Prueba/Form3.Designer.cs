namespace Primera_Prueba
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTbuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LbliD = new System.Windows.Forms.Label();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblMontoPrestamo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.TxtMonto_Prestamo = new System.Windows.Forms.TextBox();
            this.TxtCuotas = new System.Windows.Forms.TextBox();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.btnPagos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(408, 44);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(100, 20);
            this.TxtClave.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnPagos);
            this.panel1.Controls.Add(this.TXTbuscar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 326);
            this.panel1.TabIndex = 45;
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXTbuscar.FlatAppearance.BorderSize = 0;
            this.TXTbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TXTbuscar.ForeColor = System.Drawing.Color.White;
            this.TXTbuscar.Location = new System.Drawing.Point(0, 92);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(88, 23);
            this.TXTbuscar.TabIndex = 6;
            this.TXTbuscar.Text = "SEARCH";
            this.TXTbuscar.UseVisualStyleBackColor = true;
            this.TXTbuscar.Click += new System.EventHandler(this.TXTbuscar_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "LEAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(0, 69);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "SELECT";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(0, 46);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "UPDATE";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(0, 23);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(88, 23);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "INSERT";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(0, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "DELETE";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(158, 5);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 44;
            // 
            // LbliD
            // 
            this.LbliD.AutoSize = true;
            this.LbliD.Location = new System.Drawing.Point(140, 9);
            this.LbliD.Name = "LbliD";
            this.LbliD.Size = new System.Drawing.Size(24, 13);
            this.LbliD.TabIndex = 43;
            this.LbliD.Text = "ID: ";
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(524, 20);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(40, 13);
            this.lblCuotas.TabIndex = 42;
            this.lblCuotas.Text = "Cuotas";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(405, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(69, 13);
            this.lblCliente.TabIndex = 41;
            this.lblCliente.Text = "Clave Cliente";
            // 
            // lblMontoPrestamo
            // 
            this.lblMontoPrestamo.AutoSize = true;
            this.lblMontoPrestamo.Location = new System.Drawing.Point(290, 20);
            this.lblMontoPrestamo.Name = "lblMontoPrestamo";
            this.lblMontoPrestamo.Size = new System.Drawing.Size(84, 13);
            this.lblMontoPrestamo.TabIndex = 40;
            this.lblMontoPrestamo.Text = "Monto Prestamo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(98, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 39;
            this.lblFecha.Text = "Fecha";
            // 
            // TxtMonto_Prestamo
            // 
            this.TxtMonto_Prestamo.Location = new System.Drawing.Point(293, 44);
            this.TxtMonto_Prestamo.Name = "TxtMonto_Prestamo";
            this.TxtMonto_Prestamo.Size = new System.Drawing.Size(100, 20);
            this.TxtMonto_Prestamo.TabIndex = 38;
            // 
            // TxtCuotas
            // 
            this.TxtCuotas.Location = new System.Drawing.Point(527, 44);
            this.TxtCuotas.Name = "TxtCuotas";
            this.TxtCuotas.Size = new System.Drawing.Size(100, 20);
            this.TxtCuotas.TabIndex = 37;
            // 
            // dataGridViewPrestamos
            // 
            this.dataGridViewPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(105, 79);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(610, 187);
            this.dataGridViewPrestamos.TabIndex = 36;
            // 
            // btnPagos
            // 
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.Location = new System.Drawing.Point(0, 115);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(88, 23);
            this.btnPagos.TabIndex = 6;
            this.btnPagos.Text = "-----------------------------";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pagos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 326);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LbliD);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblMontoPrestamo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.TxtMonto_Prestamo);
            this.Controls.Add(this.TxtCuotas);
            this.Controls.Add(this.dataGridViewPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TXTbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LbliD;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMontoPrestamo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox TxtMonto_Prestamo;
        private System.Windows.Forms.TextBox TxtCuotas;
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPagos;
    }
}