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
    public partial class DatosCliente : Form
    {
        public DatosCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente pCliente = new Cliente();
            pCliente.Telefono = txtTelefono.Text.Trim();
            pCliente.Nombre = txtNombre.Text.Trim();
            pCliente.Calle = txtCalle.Text.Trim();
            pCliente.Colonia = txtColonia.Text.Trim();
            pCliente.Municipio = txtMunicipio.Text.Trim();
            pCliente.Referencia = txtReferencias.Text.Trim();

            int resultado = ClientesDAL.Agregar(pCliente);

            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else

            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BuscarCliente buscar = new BuscarCliente();
            buscar.ShowDialog();
        }
    }
}
