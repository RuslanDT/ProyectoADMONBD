using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROMADB
{
    class cl_inventarioDAL
    {
        public bool insertar_area(cl_areas obj)
        {
            try
            {
                string insert = "insert into Areas(nombre, ubicacion) value(@Nombre,@Ubicacion);";
                MySqlCommand comando = new MySqlCommand(insert);
                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Ubicacion", obj.Ubicacion);
                BDComun.ejecutarSentencia(comando);
                return true;
            }
            catch (Exception) { return false; }
        }

        public bool insertar_Color(Cl_Color obj)
        {
            try {
                string insert = "insert into Colores(color) values(@Color);";
                MySqlCommand comando = new MySqlCommand(insert);
                comando.Parameters.AddWithValue("@Color", obj.Color);
                BDComun.ejecutarSentencia(comando);
                return true;
            }
            catch (Exception) { return false; }
        }
    }
}
