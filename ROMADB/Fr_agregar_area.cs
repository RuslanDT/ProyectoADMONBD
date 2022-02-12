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
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
