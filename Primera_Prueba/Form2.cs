using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Primera_Prueba
{
    public partial class Form2 : Form
    {
        
        Almacen_Cliente AC = new Almacen_Cliente();
        Clientes CR = new Clientes();

        public Form2()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CR.Cedula = TxtCedula.Text;
            CR.Nombre = TxtNombre.Text;
            CR.Correo = TxtCorreo.Text;
            CR.Direccion = TxtDireccion.Text;
            CR.Telefono = Txttelefono.Text;
            AC.INSERT(CR);

            dataGridView_Cliente.DataSource = AC.SELECT();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dataGridView_Cliente.DataSource = AC.SELECT();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CR.Cedula = TxtCedula.Text;
            CR.Nombre = TxtNombre.Text;
            CR.Correo = TxtCorreo.Text;
            CR.Direccion = TxtDireccion.Text;
            CR.Telefono = Txttelefono.Text;
            CR.ID = int.Parse(TextID.Text);
            AC.UPDATE(CR);
            dataGridView_Cliente.DataSource = AC.SELECT();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CR.ID = int.Parse(TextID.Text);
            dataGridView_Cliente.DataSource = AC.SEARCH(CR);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CR.ID = int.Parse(TextID.Text);
            AC.DELETE(CR);
            dataGridView_Cliente.DataSource = AC.SELECT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
