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
    public partial class crud : Form
    {
        public crud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientesDAL obj = new ClientesDAL();
            dgvBuscar.DataSource = obj.obtner_articulos();
        }

        private void txtBuscarNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            Fr_agregar v = new Fr_agregar();
            v.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //RECUPERAMOS LOS VLAORES 
                string nombre_corto = "";
                string descripcion = "";
                string serie = "";
                string color = "";
                string tipo = "";
                string fecha = "";
                string observaciones = "";
                int id_areas = -1;
                int id_inventario = -1;

                int index = dgvBuscar.SelectedRows[0].Index;

                foreach (DataGridViewRow x in dgvBuscar.Rows)
                {
                    // SI  ESTA SELECCIONADO ENTONCES LO PASAMOS A ELIMINAR
                    if (x.Index == index)
                    {
                        id_inventario = Convert.ToInt32(x.Cells["id_inventario"].Value.ToString());
                        nombre_corto = x.Cells["nombre_corto"].Value.ToString();
                        descripcion = x.Cells["descripcion"].Value.ToString();
                        serie = x.Cells["serie"].Value.ToString();
                        color = x.Cells["color"].Value.ToString();
                        fecha = x.Cells["fecha_adquisicion"].Value.ToString();
                        tipo = x.Cells["tipo_adquisicion"].Value.ToString();
                        observaciones = x.Cells["observaciones"].Value.ToString();
                        id_areas = Convert.ToInt32(x.Cells["id_areas"].Value.ToString());

                    }

                }
            }
            catch (Exception ex) { }
            

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                //RECUPERAMOS LOS VLAORES 
                string nombre_corto = "";
                string descripcion = "";
                string serie = "";
                string color = "";
                string tipo = "";
                string fecha = "";
                string observaciones = "";
                int id_areas = -1;
                int id_inventario = -1;

                int index = dgvBuscar.SelectedRows[0].Index;

                foreach (DataGridViewRow x in dgvBuscar.Rows)
                {
                    // SI  ESTA SELECCIONADO ENTONCES LO PASAMOS A ELIMINAR
                    if (x.Index == index)
                    {
                        id_inventario = Convert.ToInt32(x.Cells["id_inventario"].Value.ToString());
                        nombre_corto = x.Cells["nombre_corto"].Value.ToString();
                        descripcion = x.Cells["descripcion"].Value.ToString();
                        serie = x.Cells["serie"].Value.ToString();
                        color = x.Cells["color"].Value.ToString();
                        fecha = x.Cells["fecha_adquisicion"].Value.ToString();
                        tipo = x.Cells["tipo_adquisicion"].Value.ToString();
                        observaciones = x.Cells["observaciones"].Value.ToString();
                        id_areas = Convert.ToInt32(x.Cells["id_areas"].Value.ToString());

                    }

                }
                //YA CON LOS DATOS SE LOS PASAMOS AL FORMULARIO DE ELIMINAR 
                Fr_modificar v = new Fr_modificar();
                v.llenar_formulario(id_inventario, nombre_corto, descripcion, serie, color, fecha, tipo, observaciones, id_areas);
                v.Show();
            }
            catch (Exception ex) { }
        }
    }
}
