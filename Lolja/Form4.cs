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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Modelo mo = new Modelo();
            DAO da = new DAO();

            mo.Usuario = txtAdm.Text;
            mo.Senha = txtSenha.Text;

            da.loginAdm(mo);

            int resultado;
            resultado = mo.Valor;

            if (resultado == 1)
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login inválido!!!! Tente Novamente");
            }

            txtAdm.Clear();
            txtSenha.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}