using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
            catch (Exception ex) { return false; }
        }
    }
}
