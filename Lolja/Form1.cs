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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Acessando o banco de dados
            Modelo mo = new Modelo();
            DAO da = new DAO();

            mo.Usuario = txtUsuario.Text;
            mo.Senha = txtSenha.Text;
            //enviar para a classe Dao
            da.login(mo);

            int resultado;

            resultado = mo.Valor;

            if (resultado == 1){
                //string texto = mo.Usuario;
                Form2 form2 = new Form2();
                form2.Show();
            }else{
                MessageBox.Show("Login invalido!!! Tente Novamente");
            }
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}