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
                string insert = "insert into Inventario(nombre_corto, descripcion, serie, color, fecha_adquisicion, tipo_adquisicion,observaciones, id_areas) values(@nombre,@descripcion,@serie,@color,@fecha,@tipo,@observaciones,@ID_areas);";
                MySqlCommand comando = new MySqlCommand(insert);

                //string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd ");
                string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                comando.Parameters.AddWithValue("nombre", item.Nombre_corto);
                comando.Parameters.AddWithValue("descripcion", item.Descripcion);
                comando.Parameters.AddWithValue("serie", item.Serie);
                comando.Parameters.AddWithValue("color", item.Color);
                comando.Parameters.AddWithValue("fecha", fechaHoy);
                comando.Parameters.AddWithValue("tipo", item.Tipo_adquisicion);
                comando.Parameters.AddWithValue("observaciones", item.Observaciones);
                comando.Parameters.AddWithValue("ID_areas", item.Id_areas);

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
                
                //LLENAMOS NUESTRA TABLA 
                DataTable tabla = BDComun.ejecutarConsulta(comando);

                List<cl_inventario> listaP = new List<cl_inventario>();

                foreach (DataRow d in tabla.Rows)
                {
                    cl_inventario aux = new cl_inventario();

                    aux.Id_inventario = Convert.ToInt32(d[0].ToString());
                    aux.Nombre_corto = d[1].ToString();
                    aux.Descripcion = d[2].ToString();
                    aux.Serie = d[3].ToString();
                    aux.Color = d[4].ToString();
                    aux.Fecha_adquisicion = d[5].ToString();
                    aux.Tipo_adquisicion = d[6].ToString();
                    aux.Observaciones = d[7].ToString();
                    aux.Id_areas = Convert.ToInt32(d[8].ToString());

                    listaP.Add(aux);
                }
                return listaP;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool eliminar_articulo(int id, string serie)
        {
            try
            {
                string delete = "delete from Inventario where id_inventario = @id and serie = @serie;";
                MySqlCommand comando = new MySqlCommand(delete);
                comando.Parameters.AddWithValue("id", id);
                comando.Parameters.AddWithValue("serie", serie);
                BDComun.ejecutarSentencia(comando);

                return true;
            }
            catch (Exception ex) { return false; }
        }

        public bool modificar(cl_inventario item)
        {
            try
            {
                string update = "update Inventario set nombre_corto = @nombre, descripcion = @descripcion, serie = @serie," +
                    "color = @color, fecha_adquisicion = @fecha, tipo_adquisicion = @tipo, observaciones = @observaciones, id_areas = @ID_area" +
                    " where id_inventario = @ID_inventario;";


                //string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd ");
                string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");


                MySqlCommand comando = new MySqlCommand(update);
                
                comando.Parameters.AddWithValue("nombre", item.Nombre_corto);
                comando.Parameters.AddWithValue("descripcion", item.Descripcion);
                comando.Parameters.AddWithValue("serie", item.Serie);
                comando.Parameters.AddWithValue("color", item.Color);
                comando.Parameters.AddWithValue("fecha", fechaHoy);
                comando.Parameters.AddWithValue("tipo", item.Tipo_adquisicion);
                comando.Parameters.AddWithValue("observaciones", item.Observaciones);
                comando.Parameters.AddWithValue("ID_area", item.Id_areas);
                comando.Parameters.AddWithValue("ID_inventario", item.Id_inventario);


                BDComun.ejecutarSentencia(comando);
                return true;
            }
            catch (Exception ex) { return false; }
        }

    }
}
