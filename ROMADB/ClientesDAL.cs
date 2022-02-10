using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ROMADB
{
    public class ClientesDAL
    {
        public static int Agregar(Cliente pCliente)
        {

            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into CLIENTE(telefono, nombre, direccion, colonia, municipio, referencias) values('{0}','{1}','{2}', '{3}','{4}', '{5}')", pCliente.Telefono, pCliente.Nombre, pCliente.Calle, pCliente.Colonia, pCliente.Municipio, pCliente.Referencia), BDComun.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }

        public static List<Cliente> Buscar(string pTelefono)
        {
            List<Cliente> lista = new List<Cliente>();

            MySqlCommand comando = new MySqlCommand(String.Format(
              "SELECT telefono, nombre, direccion, colonia, municipio, referencias FROM CLIENTE  where telefono = '{0}'", pTelefono), BDComun.ObtenerConexion());
               MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Telefono = reader.GetString(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Calle = reader.GetString(2);
                pCliente.Colonia = reader.GetString(3);
                pCliente.Municipio = reader.GetString(4);
                pCliente.Referencia = reader.GetString(5);

                lista.Add(pCliente);
            }

            return lista;
        }
        /*
        public static Cliente ObtenerCliente(string pTelefono)
        {
            Cliente pCliente = new Cliente();
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT telefono, nombre, direccion, colonia, municipio, referencias FROM CLIENTES where telefono ='{0}'", pTelefono), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                pCliente.Telefono = reader.GetString(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Calle = reader.GetString(2);
                pCliente.Colonia = reader.GetString(3);
                pCliente.Municipio = reader.GetString(4);
                pCliente.Referencia = reader.GetString(5);
            }

            conexion.Close();
            return pCliente;
        }
        */
    }
}
