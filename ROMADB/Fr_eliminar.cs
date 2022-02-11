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
    public partial class Fr_eliminar : Form
    {
        public Fr_eliminar()
        {
            InitializeComponent();
        }

        private void Fr_eliminar_Load(object sender, EventArgs e)
        {

        }
        public void llenar_formulario(int id_inventario,string nombre, string descripcion, 
            string serie, string color, string fecha, string tipo, string observaciones, int id_areas)
        {
            txtIdInventario.Text = id_inventario.ToString();
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtSerie.Text = serie;
            txtObservaciones.Text = observaciones;
            txtColor.Text = color;
            txtFecha.Text = fecha;
            txtAdquisicion.Text = tipo;
            txtArea.Text = id_areas.ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            ClientesDAL obj = new ClientesDAL();
            //PASAMOS LOS PARAMETROS PARA ELIMINAR EL ARTICULO
            int id_inve = Convert.ToInt32(txtIdInventario.Text);
            string se = txtSerie.Text;
            if (obj.eliminar_articulo(id_inve, se))
            {
                MessageBox.Show("ELIMINADO");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
