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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Diseño_menus();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            mostrar_menu(panelsubclientes);
        }

        private void btnvercliente_Click(object sender, EventArgs e)
        {
            abrir_form(new Form2());
            ocultar_menu();
        }

        private void Prestamos_Click(object sender, EventArgs e)
        {
            mostrar_menu(panelsubservicios);
        }

        private void btnprestamos_Click(object sender, EventArgs e)
        {
            abrir_form(new Form3());
            ocultar_menu();
        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            abrir_form(new Form2());
            ocultar_menu();
        }

        private void btnCclientes_Click(object sender, EventArgs e)
        {
            ocultar_menu();
        }

        private void btnCprestamos_Click(object sender, EventArgs e)
        {
            ocultar_menu();
        }

        private void btnCpagos_Click(object sender, EventArgs e)
        {
            ocultar_menu();
        }

        private void btnCbalancePendiente_Click(object sender, EventArgs e)
        {
            ocultar_menu();
        }
        private void Diseño_menus()
        {
            panelsubclientes.Visible = false;
            panelsubConsultas.Visible = false;
            panelsubservicios.Visible = false;
        }
        private void ocultar_menu()
        {
            if (panelsubclientes.Visible == true)
                panelsubclientes.Visible = false;

            if (panelsubConsultas.Visible == true)
                panelsubConsultas.Visible = false;

            if (panelsubservicios.Visible == true)
                panelsubservicios.Visible = false;

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
        private Form activeform = null;
        private void abrir_form(Form formhijo)
        {
            if (activeform != null)
                activeform.Close();
            activeform = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panel1.Controls.Add(formhijo);
            panel1.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();



        }

        
    }
}
