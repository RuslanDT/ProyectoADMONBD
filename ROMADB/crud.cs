﻿using System;
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
    }
}
