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
    class Almacen_Prestamos
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
        SqlCommand comando;

        public DataTable SELECT()
        {
            connection.Open();
            comando = new SqlCommand("select * from Prestamos", connection);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            connection.Close();
            return dt;

        }
        public void INSERT(Prestamos PC)
        {


            try
            {
                connection.Open();//Abrir conexion
                comando = new SqlCommand("InsertarPrestamos", connection); //Crear comando
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ID", SqlDbType.Int).Value = PC.ID_P;
                comando.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = PC.Fecha;
                comando.Parameters.Add("@Monto", SqlDbType.Int).Value = PC.Monto;
                comando.Parameters.Add("@cliente_ID", SqlDbType.VarChar).Value = PC.clienteID;
                comando.Parameters.Add("@Cuotas", SqlDbType.Int).Value = PC.Cuota;
                comando.ExecuteNonQuery(); //Ejecutar commando
                connection.Close(); //Cerrar conexion

            }catch(Exception error){

                MessageBox.Show(error.Message);
            }


        }
        public void UPDATE(Prestamos PC)
        {
            try
            {
                connection.Open();//Abrir conexion
                comando = new SqlCommand("EditarPrestamos", connection); //Crear comando
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = PC.Fecha;
                comando.Parameters.Add("@Monto", SqlDbType.Int).Value = PC.Monto;
                comando.Parameters.Add("@Cliente_ID", SqlDbType.VarChar).Value = PC.clienteID;
                comando.Parameters.Add("@Cuotas", SqlDbType.Int).Value = PC.Cuota;
                comando.Parameters.Add("@ID", SqlDbType.Int).Value = PC.ID_P;
                comando.ExecuteNonQuery(); //Ejecutar commando
                connection.Close(); //Cerrar conexion
                MessageBox.Show("Editado");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
        public void DELETE(Prestamos PC)
        {
            try
            {
                connection.Open();//Abrir conexion
                comando = new SqlCommand("EliminarPrestamos", connection); //Crear comando
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ID", SqlDbType.Int).Value = PC.ID_P;
                comando.ExecuteNonQuery(); //Ejecutar commando
                connection.Close(); //Cerrar conexion
                MessageBox.Show("ELIMINADO");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        public DataTable SEARCH(Prestamos PC)
        {     
                connection.Open();//Abrir conexion
                comando = new SqlCommand("BuscarPrestamos", connection); //Crear comando
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ID", SqlDbType.Int).Value = PC.ID_P;
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
    public class Busqueda{
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
        SqlCommand comando;
         public void Buscar_ID_F4(int ID)
        {
            connection.Open();//Abrir conexion
            comando = new SqlCommand("Pago", connection); //Crear comando
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            comando.ExecuteNonQuery(); //Ejecutar commando
            connection.Close(); //Cerrar conexion
           
        }
        public DataTable SELECTMovimientoprestamos()
        {
            connection.Open();
            comando = new SqlCommand("select * from MovimintoPrestamos", connection);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            connection.Close();
            return dt;

        }
        public void BUSCAR_ID_F4(int ID)
        {
            connection.Open();//Abrir conexion
            comando = new SqlCommand("Pago2", connection); //Crear comando
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            comando.ExecuteNonQuery(); //Ejecutar commando
            connection.Close(); //Cerrar conexion
           
        }
    }
   
}
