using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Lolja
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet3.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.lojaDataSet3.produtos);
            //carregar combo box
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "SERVER=localhost;DATABASE=loja;UID=root;PASSWORD= ;";
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            //recebe a string do select categorias
            comando.CommandText = "SELECT desc_categoria from Categorias";
            //executa o select
            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbCategoria.DisplayMember = "desc_categoria";
            cmbCategoria.DataSource = dt;
            
            //desabilitar os campos
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            btnCadastrar.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txtDescricao.Text == "") && (txtValor.Text == ""))
            {
                MessageBox.Show("Necessário o preenchimento! ");

            }
            else
            {
                Modelo mo = new Modelo();
                DAO da = new DAO();

                mo.DescProduto = txtDescricao.Text;
                mo.ValorProduto = Convert.ToDecimal(txtValor.Text);
                string categoria = cmbCategoria.Text.ToString();
                mo.Categoria = categoria;

                da.cadastroProduto(mo);
                txtDescricao.Clear();
                txtValor.Clear();
                txtDescricao.Enabled = false;
                txtValor.Enabled = false;
                btnCadastrar.Enabled = false;
                MessageBox.Show("Produto cadastrado com sucesso! ");
                this.produtosTableAdapter.Fill(this.lojaDataSet3.produtos);


            }

 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if ((txtDescricao.Text == "") && (txtValor.Text == ""))
            {
                MessageBox.Show("Necessário preencher campos");
            }
            else
            {
                Modelo mo = new Modelo();
                DAO da = new DAO();

                mo.DescProduto = txtDescricao.Text;
                mo.ValorProduto = Convert.ToDecimal(txtValor.Text);
                mo.CodProduto = int.Parse(txtValor.Text);
                //falta categoria


                da.alterarProduto(mo);

                MessageBox.Show("Produto alterado com sucesso");

                txtDescricao.Clear();
                txtValor.Clear();
                txtCodigo.Clear();
                desabilita_campos(sender, e);
                btnNovo.Enabled = true;

                this.produtosTableAdapter.Fill(this.lojaDataSet3.produtos);
            }
        }
               private void desabilita_campos(object sender, EventArgs e)
        {
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

           private void habilita_campos(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilita_campos(sender, e);
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = false;

            DataGridViewRow LinhaSelecionada;
            LinhaSelecionada = dataGridView1.CurrentRow;
            txtCodigo.Text = LinhaSelecionada.Cells[1].Value.ToString();
            txtDescricao.Text = LinhaSelecionada.Cells[0].Value.ToString();
            txtValor.Text = LinhaSelecionada.Cells[2].Value.ToString();

            //faltou categoria
        }
    }
     
}
