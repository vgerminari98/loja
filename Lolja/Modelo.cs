using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lolja
{
    class Modelo
    {
        private int nCodigo;
        private string nUsuario;
        private string nSenha;
        private int nValor;
        private string nCategoria;
        private int nCodCategoria;
        private string nDescProduto;
        private decimal nValorProduto;
        private int nCodProduto;
        private int nCodCliente;
        private string nNome;
        private string nCpf;
        private string nRg;
        private int nIdade;
        private string nEndereco;
        private string nNumero;
        private string nCidade;
        private string nBairro;
        private string nTelefone;
        private string nCelular;
        private string nEmail;
        private DateTime nData;
        private decimal nValorTotal;



        public int Codigo
        {
            get { return nCodigo; }
            set { nCodigo = value; }
        }

        public string Senha
        {
            get { return nSenha; }
            set { nSenha = value; }
        }

        public string Usuario
        {
            get { return nUsuario; }
            set { nUsuario = value; }
        }

        public int Valor
        {
            get { return nValor; }
            set { nValor = value; }
        }

        public string Categoria
        {
            get { return nCategoria; }
            set { nCategoria = value; }
        }

        public int CodCategoria
        {
            get { return nCodCategoria; }
            set { nCodCategoria = value; }
        }

        public string Nome
        {
            get { return nNome; }
            set { nNome = value; }
        }

        public string Cpf
        {
            get { return nCpf; }
            set { nCpf = value; }
        }
        public string Rg
        {
            get { return nRg; }
            set { nRg = value; }
        }
        public int Idade
        {
            get { return nIdade; }
            set { nIdade = value; }
        }

        public string Endereco
        {
            get { return nEndereco; }
            set { nEndereco = value; }
        }
        public string Numero
        {
            get { return nNumero; }
            set { nNumero = value; }
        }
        public string Cidade
        {
            get { return nCidade; }
            set { nCidade = value; }
        }

        public string Bairro
        {
            get { return nBairro; }
            set { nBairro = value; }
        }
        public string Telefone
        {
            get { return nTelefone; }
            set { nTelefone = value; }
        }
        public string Celular
        {
            get { return nCelular; }
            set { nCelular = value; }
        }
        public string Email
        {
            get { return nEmail; }
            set { nEmail = value; }
        }

        public string DescProduto
        {
            get { return nDescProduto; }
            set { nDescProduto = value; }
        }

        public decimal ValorProduto
        {
            get { return nValorProduto; }
            set { nValorProduto = value; }
        }

        public int CodProduto
        {
            get { return nCodProduto; }
            set { nCodProduto = value; }
        }
    }
}
