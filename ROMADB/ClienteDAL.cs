using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ROMADB
{
    public class ClientesDAL
    {
        public bool insertar_en_inventario(cl_inventario item)
        {

            try
            {
                string insert = "insert into inventario(nombre_corto, descripcion, serie, color, fecha_adquisicion, " +
                    "tipo_adquisicion,observaciones, id_areas) values(@nombre,@descripcion,@serie,@color,@fecha,@tipo,@obsercaciones,@id_areas);";
                MySqlCommand comando = new MySqlCommand(insert);

                //string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd ");
                string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                comando.Parameters.AddWithValue("?nombre", item.Nombre_corto);
                comando.Parameters.AddWithValue("?descripcion", item.Descripcion);
                comando.Parameters.AddWithValue("?serie", item.Serie);
                comando.Parameters.AddWithValue("?color", item.Color);
                comando.Parameters.AddWithValue("?fecha", fechaHoy);
                comando.Parameters.AddWithValue("?tipo", item.Tipo_adquisicion);
                comando.Parameters.AddWithValue("?obsercaciones", item.Observaciones);
                comando.Parameters.AddWithValue("?id_areas", item.Id_areas);

                BDComun.ejecutarSentencia(comando);

                return true;
            }
            catch (Exception ex) { return false; }

            

        }

       

        //MOSTRAR TODO LO QUE ESTE EN INVENTARIO
        public List<cl_inventario> obtner_articulos()
        {
            try
            {
                string select = "SELECT * from Inventario;";
                MySqlCommand comando = new MySqlCommand(select);
                BDComun.ejecutarConsulta(comando);
                //LLENAMOS NUESTRA TABLA 
                DataTable tabla = BDComun.ejecutarConsulta(comando);

                List<cl_inventario> listaP = new List<cl_inventario>();
                foreach (DataRow d in tabla.Rows)
                {
                    cl_inventario aux = new cl_inventario();
                    aux.Nombre_corto = d[0].ToString();
                    aux.Descripcion = d[1].ToString();
                    aux.Serie = d[2].ToString();
                    aux.Color = d[3].ToString();
                    aux.Fecha_adquisicion = d[3].ToString();
                    aux.Tipo_adquisicion = d[4].ToString();
                    aux.Observaciones = d[5].ToString();

                    listaP.Add(aux);
                }
                return listaP;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool eliminar_articulo(int id)
        {
            try
            {
                string delete = "delete from inventario where id = @id;";
                MySqlCommand comando = new MySqlCommand(delete);
                comando.Parameters.AddWithValue("?id", id);
                BDComun.ejecutarSentencia(comando);

                return true;
            }
            catch (Exception ex) { return false; }
        }

    }
}
