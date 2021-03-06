using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ROMADB
{
    public class BDComun
    {
       
        static MySqlConnection conect;
        public static bool conectar()
        {
      
            string conexion = "server = localhost; database = proyecto_admon_bd; " + "uid = nuevo_user; pwd = 1234;";
            try
            {
                conect = new MySqlConnection(conexion);
                conect.Open();
                return true;
            }
            catch (Exception ) { return false; }
        }
        public static void desconectar()
        {
            if (conect != null && conect.State == ConnectionState.Open)
            {
                conect.Close();
                conect.Dispose();
            }
        }
        //METODO PARA LOS UPDATE, DELETE EN LA BD
        public static void ejecutarSentencia(MySqlCommand comando)
        {
            try
            {
                if (conectar())
                {
                    comando.Connection = conect;
                    comando.ExecuteNonQuery();
                }

            }
            catch (Exception )
            {

            }
            finally
            {
                desconectar();
            }
        }
        //METODO PARA TRAER LA CONSULTA EN UNA TABLA
        public static DataTable ejecutarConsulta(MySqlCommand comando)
        {
            if (conectar())
            {
                try
                {
                    comando.Connection = conect;
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable resultado_consulta = new DataTable();
                    adaptador.Fill(resultado_consulta);
                    return resultado_consulta;
                }
                catch (Exception )
                {
                    return null;
                }
                finally
                {
                    desconectar();
                }

            }
            else
            {
                return null;
            }
        }


    }
}
