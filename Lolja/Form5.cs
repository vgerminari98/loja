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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo mo = new Modelo();
            DAO da = new DAO();

            mo.Usuario = txtUsuario.Text;
            mo.Senha = txtSenha.Text;

            //verifica se ja existe um usuario com mesmo nome na base de dados

            da.verificaUsuario(mo);
            int resultado;
            resultado = mo.Valor;

            if (resultado >= 1)
            {
                MessageBox.Show("Já existe usuario com este nome!!! Digite outro nome de usuario.");
                    txtUsuario.Clear();
            }
            else
            {
                da.cadastro(mo);

                txtUsuario.Clear();
                txtSenha.Clear();

                MessageBox.Show("Usuario cadastrado com sucesso");

                this.Close();
            }


        }
    }
}
