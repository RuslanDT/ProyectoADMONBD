using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ROMADB
{
    public partial class Fr_agregar : Form
    {
        public Fr_agregar()
        {
            InitializeComponent();
            llenarCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS LOS VLAORES 
            string nombre_corto = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string serie = txtSerie.Text;
            string color = coColor.SelectedItem.ToString();
            string tipo = txtAdquisicion.Text;
            string observaciones = txtObservaciones.Text;
            int id_areas = Convert.ToInt32(coAreas.SelectedItem.ToString());

            //PASAMOS LOS VALORES AL OBJETO DE INVENTARIO
            cl_inventario obj = new cl_inventario();
            obj.Nombre_corto = nombre_corto;
            obj.Descripcion = descripcion;
            obj.Serie = serie;
            obj.Color = color;
            obj.Tipo_adquisicion = tipo;
            obj.Observaciones = observaciones;
            obj.Id_areas = id_areas;

            ClientesDAL objDAL = new ClientesDAL();
            if (objDAL.insertar_en_inventario(obj))
            {
                MessageBox.Show("AGREGADO");
            }
            else
            {
                MessageBox.Show("OCURRIO UN ERROR");
            }

            txtAdquisicion.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtObservaciones.Text = "";
            txtSerie.Text = "";


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void llenarCombo()
        {
            string select = "select nombre from Areas;";
            MySqlCommand comando = new MySqlCommand(select);
            DataTable tabla = BDComun.ejecutarConsulta(comando);

            List<string> comb = new List<string>();
            foreach (DataRow row in tabla.Rows)
            {

                comb.Add(row[0].ToString());

            }
            coAreas.DataSource = comb;
        }

        private void btn_agregar_area_Click(object sender, EventArgs e)
        {
            Fr_agregar_area v = new Fr_agregar_area();
            v.Show();
        }
    }
}
