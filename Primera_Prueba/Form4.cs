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
    public partial class Form4 : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
        SqlCommand comando;
        Almacen_Prestamos AP = new Almacen_Prestamos();
        Busqueda busqueda = new Busqueda();
       
        public Form4()
        {
            InitializeComponent();
            Diseño_menus();
        }
        private void Diseño_menus()
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }
        private void ocultar_menu()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;

            if (panel2.Visible == true)
                panel2.Visible = false;
        }
        private void mostrar_menu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultar_menu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrar_menu(panel1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrar_menu(panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=SEARCH();
        }
        public DataTable SEARCH()
        {
            connection.Open();//Abrir conexion
            comando = new SqlCommand("BuscarPrestamos2", connection); //Crear comando
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@ID", SqlDbType.VarChar).Value = TxtBuscarCliente.Text;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(comando);
            DA.Fill(dt);
            connection.Close(); //Cerrar conexion
            return dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            busqueda.Buscar_ID_F4(int.Parse(textID.Text));
            dataGridView1.DataSource = busqueda.SELECTMovimientoprestamos();
            
        }

        private void BTNtotalcuota_Click(object sender, EventArgs e)
        {
            busqueda.BUSCAR_ID_F4(int.Parse(textID.Text));
            dataGridView1.DataSource = busqueda.SELECTMovimientoprestamos();
        }
        

       
    }
}
