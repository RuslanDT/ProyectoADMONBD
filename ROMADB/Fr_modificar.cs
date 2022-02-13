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
    public partial class Fr_modificar : Form
    {
        static int id_inven;
        public Fr_modificar()
        {
            InitializeComponent();
            llenar_combo_area();
            llenarComboColores();
        }

        

        private void llenar_combo_area()
        {
            string select = "select id_areas from Areas;";
            MySqlCommand comando = new MySqlCommand(select);
            DataTable tabla = BDComun.ejecutarConsulta(comando);

            List<string> comb = new List<string>();
            foreach (DataRow row in tabla.Rows)
            {

                comb.Add(row[0].ToString());

            }
            coArea.DataSource = comb;
        }

        public void llenar_formulario(int id_inventario, string nombre, string descripcion,
            string serie, string color, string fecha, string tipo, string observaciones, int id_areas)
        {
            id_inven = Convert.ToInt32(id_inventario.ToString());
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtSerie.Text = serie;
            txtObservaciones.Text = observaciones;
            txtAdquisicion.Text = tipo;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            cl_inventario obj = new cl_inventario();
            obj.Id_inventario = id_inven;
            obj.Nombre_corto = txtNombre.Text;
            obj.Descripcion = txtDescripcion.Text;
            obj.Color = coColor.SelectedItem.ToString();
            obj.Serie = txtSerie.Text;
            obj.Tipo_adquisicion = txtAdquisicion.Text;
            obj.Observaciones = txtObservaciones.Text;
            obj.Id_areas = Convert.ToInt32(coArea.SelectedItem.ToString());
            
            ClientesDAL objDAL = new ClientesDAL();
            if (objDAL.modificar(obj))
            {
                MessageBox.Show("MODIFICADO CON EXITO");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void llenarComboColores()
        {
            string select = "select color from colores;";
            MySqlCommand comando = new MySqlCommand(select);
            DataTable tabla = BDComun.ejecutarConsulta(comando);

            List<string> comb = new List<string>();
            foreach (DataRow row in tabla.Rows)
            {

                comb.Add(row[0].ToString());

            }
            coColor.DataSource = comb;
        }

        private void btnAgregarArea_Click(object sender, EventArgs e)
        {
            Fr_agregar v = new Fr_agregar();
            v.ShowDialog();
        }

        private void btnAgregarColor_Click(object sender, EventArgs e)
        {
            fr_AgregarColor f = new fr_AgregarColor();
            f.ShowDialog();
        }
    }
}
