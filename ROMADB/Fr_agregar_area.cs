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
    public partial class Fr_agregar_area : Form
    {
        public Fr_agregar_area()
        {
            InitializeComponent();
            llenarComboAreas();
            lblArea.Visible = false;
            cBoxAreas.Visible = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (chckAgregar.Checked)
            {
                try
                {
                    string nombre = txtNombre.Text;
                    string ubicacion = txtUbicacion.Text;

                    cl_areas obj = new cl_areas();
                    obj.Nombre = nombre;
                    obj.Ubicacion = ubicacion;

                    cl_inventarioDAL daoIn = new cl_inventarioDAL();
                    if (daoIn.insertar_area(obj))
                    {
                        MessageBox.Show("AGREGADA");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
                catch (Exception) { }

            }
            else if (chckModificar.Checked)
            {
                try
                {
                    string nombre = txtNombre.Text;
                    string ubicacion = txtUbicacion.Text;

                    cl_areas obj = new cl_areas();
                    obj.Nombre = nombre;
                    obj.Ubicacion = ubicacion;

                    ClientesDAL daoIn = new ClientesDAL();
                    if (daoIn.modiArea(obj, cBoxAreas.SelectedItem.ToString()))
                    {
                        MessageBox.Show("MODIFICADAs");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
                catch (Exception) { }
            }

            txtNombre.Text = "";
            txtUbicacion.Text = "";
            llenarComboAreas();
        }

        private void llenarComboAreas()
        {
            string select = "select nombre from Areas;";
            MySqlCommand comando = new MySqlCommand(select);
            DataTable tabla = BDComun.ejecutarConsulta(comando);

            List<string> comb = new List<string>();
            foreach (DataRow row in tabla.Rows)
            {

                comb.Add(row[0].ToString());

            }
           cBoxAreas.DataSource = comb;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chckModificar_CheckedChanged(object sender, EventArgs e) {
            chckAgregar.Checked = false;
            lblArea.Visible = true;
            cBoxAreas.Visible = true;
            lblNombre.Enabled = true;
            lblUbicacion.Enabled = true;
            txtNombre.Enabled = true;
            txtUbicacion.Enabled = true;
            btn_agregar.Text = "MODIFICAR";
            this.Text = "MODIFICAR ÁREA";
            txtNombre.Text = "";
            txtUbicacion.Text = "";
        }

        private void chckAgregar_CheckedChanged(object sender, EventArgs e) {
            chckModificar.Checked = false;
            lblArea.Visible = false;
            cBoxAreas.Visible = false;
            lblNombre.Enabled = true;
            lblUbicacion.Enabled = true;
            txtNombre.Enabled = true;
            txtUbicacion.Enabled = true;
            btn_agregar.Text = "AGREGAR";
            this.Text = "AGREGAR ÁREA";
            txtNombre.Text = "";
            txtUbicacion.Text = "";
        }

        private void cBoxAreas_DropDownClosed(object sender, EventArgs e)
        {
            txtNombre.Text = cBoxAreas.SelectedItem.ToString();

            //SE MUESTRA LA UBICACION DEL AREA SELECCIONADA
            try
            {
                string select = "select ubicacion from areas where nombre = @nombre;";
                MySqlCommand comando = new MySqlCommand(select);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);

                DataTable tabla = BDComun.ejecutarConsulta(comando);

                foreach (DataRow row in tabla.Rows)
                {

                    txtUbicacion.Text = (row[0].ToString());

                }
            }
            catch (Exception) { MessageBox.Show("OCURRIO UN FALLO"); }
        }
    }
}
