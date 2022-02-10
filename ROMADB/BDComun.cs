using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ROMADB
{
    public class BDComun
    {
        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection
                ("server = localhost; database = roma; Uid = root; pwd = reptiles12;");

            conectar.Open();

            return conectar;
        }
    }
}
