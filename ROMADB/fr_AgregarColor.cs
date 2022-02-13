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
    public partial class fr_AgregarColor : Form
    {
        public fr_AgregarColor()
        {
            InitializeComponent();
            cBoxColores.Visible = false;
            lblNuevoColor.Visible = false;
            txtColor2.Visible = false;
            llenarComboColores();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (!chckModificarColor.Checked)
            {
                //RECUPERAMOS LOS VLAORES 
                string color = txtColor.Text;

                //PASAMOS LOS VALORES AL OBJETO DE INVENTARIO
                Cl_Color obj = new Cl_Color();
                obj.Color = color;

                cl_inventarioDAL objDAL = new cl_inventarioDAL();
                if (objDAL.insertar_Color(obj))
                {
                    MessageBox.Show("AGREGADO");
                }
                else
                {
                    MessageBox.Show("OCURRIO UN ERROR");
                }

                txtColor.Text = "";

            } else {

                //RECUPERAMOS LOS VLAORES 
                string color = txtColor2.Text;

                //PASAMOS LOS VALORES AL OBJETO DE INVENTARIO
                Cl_Color obj = new Cl_Color();
                obj.Color = color;

                ClientesDAL objDAL = new ClientesDAL();
                if (objDAL.modiColor(obj, cBoxColores.SelectedItem.ToString()))
                {
                    MessageBox.Show("MODIFICADO");
                }
                else
                {
                    MessageBox.Show("OCURRIO UN ERROR");
                }

                txtColor2.Text = "";
            }

            llenarComboColores();
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
            cBoxColores.DataSource = comb;
        }

        private void chckModificarColor_CheckedChanged(object sender, EventArgs e)
        {
            if (chckModificarColor.Checked) {
                txtColor.Visible = false;
                btn_agregar.Text = "MODIFICAR";
                cBoxColores.Visible = true;
                lblNuevoColor.Visible = true;
                txtColor2.Visible = true;
                lblColor.Text = "Color: ";
                this.Text = "MODIFICAR COLOR";

            } else {
                txtColor.Visible = true;
                btn_agregar.Text = "AGREGAR";
                cBoxColores.Visible = false;
                lblNuevoColor.Visible = false;
                txtColor2.Visible = false;
                lblColor.Text = "Nuevo Color: ";
                this.Text = "AGREGAR COLOR";
            }
        }
    }
}
