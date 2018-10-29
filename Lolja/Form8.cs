using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lolja
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet5.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.lojaDataSet5.produtos);
            // TODO: This line of code loads data into the 'lojaDataSet4.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.lojaDataSet4.clientes);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}