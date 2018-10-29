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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.categoriasTableAdapter1.FillBy(this.lojaDataSet1.categorias);
            txtCategoria.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;
            txtCategoria.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Modelo mo = new Modelo();
            DAO da = new DAO();

            mo.Categoria = txtCategoria.Text;

            da.categoria(mo);

            txtCategoria.Clear();

            MessageBox.Show("Categoria cadastrada com sucesso");

            txtCategoria.Enabled = false;
            this.categoriasTableAdapter1.FillBy(this.lojaDataSet1.categorias);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriasTableAdapter1.FillBy(this.lojaDataSet1.categorias);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "") 
            {
                MessageBox.Show("Necessário escolher uma categoria");
            }

            else
            {
                Modelo mo = new Modelo();
                DAO da = new DAO();

                mo.Categoria = txtCategoria.Text;

                da.excluirCategoria(mo);

                MessageBox.Show("Categoria excluida com sucesso");

                txtCategoria.Clear();
                txtCategoria.Enabled = false;

                this.categoriasTableAdapter1.FillBy(this.lojaDataSet1.categorias);
            }
        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoria.Enabled = true;
            DataGridViewRow LinhaSelecionada;
            //quando clicar num registro DataGrid ele preenche o textbox com o registro
            LinhaSelecionada = dataGridView1.CurrentRow;
            lblCodigo.Text = LinhaSelecionada.Cells[0].Value.ToString();
            txtCategoria.Text = LinhaSelecionada.Cells[1].Value.ToString();
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Necessário escolher uma categoria");
            }
            else
            {
                Modelo mo = new Modelo();
                DAO da = new DAO();

                mo.Categoria = txtCategoria.Text;

                mo.CodCategoria = int.Parse(lblCodigo.Text);

                da.alterarCategoria(mo);

                MessageBox.Show("Categoria alterada com sucesso");

                this.categoriasTableAdapter1.FillBy(this.lojaDataSet1.categorias);

                txtCategoria.Clear();
                txtCategoria.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
            txtCategoria.Enabled = false;
        }
    }
}