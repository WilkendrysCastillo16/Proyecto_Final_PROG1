using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Primera_Prueba
{
    class Almacen_Cliente
    {
        
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
        SqlCommand comando;

        public DataTable SELECT()
        {
            connection.Open();
            comando = new SqlCommand("select * from Clientes", connection);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            connection.Close();
            return dt;

        }
        public void INSERT(Clientes CR)
        {
            connection.Open();//Abrir conexion
            comando = new SqlCommand("InsertarCliente", connection); //Crear comando
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = CR.Cedula;
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = CR.Nombre;
            comando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = CR.Correo;
            comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = CR.Direccion;
            comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = CR.Telefono;
            comando.ExecuteNonQuery(); //Ejecutar commando
            connection.Close(); //Cerrar conexion



        }
        public void UPDATE(Clientes CR)
        {
            try
            {
                connection.Open();//Abrir conexion
                comando = new SqlCommand("EditarCliente", connection); //Crear comando
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = CR.Cedula;
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = CR.Nombre;
                comando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = CR.Correo;
                comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = CR.Direccion;
                comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = CR.Telefono;
                comando.Parameters.Add("@ID", SqlDbType.Int).Value = CR.ID;
                comando.ExecuteNonQuery(); //Ejecutar commando
                connection.Close(); //Cerrar conexion
                MessageBox.Show("Editado");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
        public void DELETE(Clientes CR)
        {
            try
            {
                connection.Open();//Abrir conexion
                comando = new SqlCommand("EliminarCliente", connection); //Crear comando
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ID", SqlDbType.Int).Value = CR.ID;
                comando.ExecuteNonQuery(); //Ejecutar commando
                connection.Close(); //Cerrar conexion
                MessageBox.Show("ELIMINADO");

            }catch(Exception error){
                MessageBox.Show(error.Message);
            }

        }
        public DataTable SEARCH(Clientes CR)
        {

            connection.Open();//Abrir conexion
            comando = new SqlCommand("BuscarCliente", connection); //Crear comando
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = CR.ID;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(comando);
            DA.Fill(dt);
            connection.Close(); //Cerrar conexion
            return dt;


            //string BUSCAR = "SELECT * From Clientes WHERE  ID='"+CR.ID+"'";
            //connection.Open();//Abrir conexion
            //comando = new SqlCommand(BUSCAR,connection);
            //comando.ExecuteNonQuery();
            //DataTable Tabla = new DataTable();
            //SqlDataAdapter DA = new SqlDataAdapter(comando);
            //DA.Fill(Tabla);
            //connection.Close(); //Cerrar conexion
            //return Tabla;
            
        }





    }
}
