using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primera_Prueba
{
    public partial class Form3 : Form
    {
        Almacen_Prestamos AP = new Almacen_Prestamos();
        Prestamos PC = new Prestamos();
        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            mostrarDataGriedView();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            PC.ID_P = int.Parse(TxtID.Text);
            PC.Fecha = dateTimePicker1.Text;
            PC.Monto = int.Parse( TxtMonto_Prestamo.Text);
            PC.clienteID = TxtClave.Text;
            PC.Cuota = int.Parse(TxtCuotas.Text);

            AP.INSERT(PC);
            mostrarDataGriedView();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PC.Fecha = dateTimePicker1.Text;
            PC.Monto = int.Parse(TxtMonto_Prestamo.Text);
            PC.clienteID = TxtClave.Text;
            PC.Cuota = int.Parse(TxtCuotas.Text);
            PC.ID_P = int.Parse(TxtID.Text);
            AP.UPDATE(PC);
            mostrarDataGriedView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PC.ID_P = int.Parse(TxtID.Text);
            AP.DELETE(PC);
            mostrarDataGriedView();
        }

        private void TXTbuscar_Click(object sender, EventArgs e)
        {
            PC.ID_P = int.Parse(TxtID.Text);
            dataGridViewPrestamos.DataSource = AP.SEARCH(PC);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 F4 = new Form4();
            F4.Show();

        }

        public void mostrarDataGriedView()
        {
            dataGridViewPrestamos.DataSource = AP.SELECT();
        }
       
    }
}
