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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = true;
            txtNome.Enabled = true;
            txtNome.Focus();
            mskCpf.Enabled = true;
            txtRg.Enabled = true;
            txtIdade.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            mskTelefone.Enabled = true;
            mskCelular.Enabled = true;
            txtEmail.Enabled = true;
            btnNovo.Enabled = false;

        }
        private void Form6_Load(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            txtNome.Enabled = false;
            mskCpf.Enabled = false;
            txtRg.Enabled = false;
            txtIdade.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            mskTelefone.Enabled = false;
            mskCelular.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text == "") && (mskCpf.Text == "") && (txtRg.Text == ""))
            {
                MessageBox.Show("Necessário o preenchimento dos dados");
            }
            else
            {
                Modelo mo = new Modelo();
                DAO da = new DAO();

                mo.Nome = txtNome.Text;
                mo.Cpf = mskCpf.Text;
                mo.Rg = txtRg.Text;
                mo.Idade = Convert.ToInt32(txtIdade.Text);
                mo.Endereco = txtEndereco.Text;
                mo.Cidade = txtCidade.Text;
                mo.Bairro = txtBairro.Text;
                mo.Telefone = mskTelefone.Text;
                mo.Celular = mskCelular.Text;
                mo.Email = txtEmail.Text;

                da.CadastroCliente(mo);
                txtNome.Clear();
                mskCpf.Clear();
                txtRg.Clear();
                txtIdade.Clear();
                txtEndereco.Clear();
                txtBairro.Clear();
                mskTelefone.Clear();
                mskCelular.Clear();
                txtEmail.Clear();

                btnNovo.Enabled = true;
                btnCadastrar.Enabled = false;
                txtNome.Enabled = false;
                mskCpf.Enabled = false;
                txtRg.Enabled = false;
                txtIdade.Enabled = false;
                txtEndereco.Enabled = false;
                txtNumero.Enabled = false;
                txtCidade.Enabled = false;
                txtBairro.Enabled = false;
                mskTelefone.Enabled = false;
                mskCelular.Enabled = false;
                txtEmail.Enabled = false;

                this.clientesTableAdapter.Fill(this.lojaDataSet2.clientes);
                MessageBox.Show("Cliente cadastrado com sucesso!!");

            }

        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet2.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.lojaDataSet2.clientes);

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
         
        }
    }
}