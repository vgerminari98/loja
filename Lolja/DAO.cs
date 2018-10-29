using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Threading;
using MySql.Data;

namespace Lolja
{
    class DAO
    {
        private MySqlConnection conexao;
        string caminho = "SERVER=localhost;DATABASE=loja;UID=root;PASSWORD='';";

        //private String usuario;
        //private String senha;

        //Login de Usuario
        public void login(Modelo mo)
        {
            try
            {
                //conexao seja criada
                conexao = new MySqlConnection(caminho);
                // abrir a conexão
                conexao.Open();
                // inserir a string de select dentro da variavel comprar
                String comparar = "SELECT COUNT(*) FROM usuarios WHERE usuario_user='" + mo.Usuario + "' and senha_user='" + mo.Senha + "'";
                MySqlCommand comandos = new MySqlCommand(comparar, conexao);

                int valor = int.Parse(comandos.ExecuteScalar().ToString());
                mo.Valor = valor;

                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel se conectar " + ex.Message);
            }
        }

        //Cadastrar categoria
        public void categoria(Modelo mo)
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                /*inserir a string de select dentro da variavel comprar
                String compararProduto = "SELECT COUNT(*) FROM desc_categoria WHERE categoria='" + mo.Categoria+"'";
                MySqlCommand comandos = new MySqlCommand(compararProduto, conexao);

                int valor = int.Parse(comandos.ExecuteScalar().ToString());
                mo.Valor = valor;
                 * 
                 *  string up = "UPDATE categorias SET estado=true where desc_categoria='" + mo.Categoria + "'";
                 * 

                conexao.Close();*/

                string inserir = "INSERT INTO CATEGORIAS(desc_categoria, estado) values('" + mo.Categoria + "'" + ", true" + ")";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);

                comandos.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }

        //Excluir Categoria 
        public void excluirCategoria(Modelo mo)
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string excluir = "UPDATE categorias SET estado=false where desc_categoria='" + mo.Categoria + "'";
                MySqlCommand comandos = new MySqlCommand(excluir,conexao);

                comandos.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos" + ex.Message);
            }
        }

        //Alterar Categoria
        public void alterarCategoria(Modelo mo)
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string alterar = "UPDATE categorias SET desc_categoria='" + mo.Categoria + "'WHERE codigo_categoria ='" + mo.CodCategoria + "'";
                MySqlCommand comandos = new MySqlCommand(alterar, conexao);

                comandos.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos" + ex.Message);
            }
        }

        public void loginAdm(Modelo mo)
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string comparar = "SELECT COUNT(*) FROM administrador WHERE usuario_adm='" + mo.Usuario + "' AND senha_adm='" + mo.Senha + "'";

                MySqlCommand comandos = new MySqlCommand(comparar, conexao);

                int valor = int.Parse(comandos.ExecuteScalar().ToString());

                mo.Valor = valor;

                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void cadastro(Modelo mo)
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string inserir = "Insert into usuarios(usuario_user, senha_user) values ('" + mo.Usuario
                + "','" + mo.Senha + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);

                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }
        }

        public void verificaUsuario(Modelo mo)
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string comparar = "select count(*) from usuarios where usuario_user = '" + mo.Usuario + "'";
                MySqlCommand comandos = new MySqlCommand(comparar, conexao);

                int valor = int.Parse(comandos.ExecuteScalar().ToString());
                mo.Valor = valor;

                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }
        }

        public void CadastroCliente(Modelo mo) 
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string inserir = "Insert into Clientes(nome,cpf,rg,idade,endereco,numero,cidade,bairro,telefone,celular,email) values('"+
                    mo.Nome + "','" + mo.Cpf + "','" + mo.Rg + "'," + mo.Idade + ",'" + mo.Endereco + "','" + mo.Numero + "','" +
                    mo.Cidade + "','" + mo.Bairro + "','" + mo.Telefone + "','" + mo.Celular + "','" + mo.Email + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);

                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }
        }

        public void cadastroProduto(Modelo mo)
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                //categoriastr recebe o select que sera executado
                string categoriastr = "SELECT codigo_categoria from categorias where desc_categoria='" + mo.Categoria + "'";
                //cat recebe a execução do select
                MySqlCommand cat = new MySqlCommand(categoriastr, conexao);
                //categoriaint recebe a conversão da execução da string para int
                int categoriaint = int.Parse(cat.ExecuteScalar().ToString());

                //inserir recebe a string do insert ja com todos os produtos devidamente convertidos
                string inserir = "INSERT INTO Produtos(desc_produto, valor, codigo_categoria)values('" + mo.DescProduto + "'," + mo.ValorProduto + "," + categoriaint + ")";
                //comandos recebe os parametros para serem executados o insert na conexao
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                //comandos sera executado
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }
        }

        //altera Produto
        public void alterarProduto(Modelo mo) 
        {
            try {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                //transforma formato do valor para americano
                double numero = Convert.ToDouble(mo.ValorProduto);
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Convert.ToDouble(numero);

                string alterar = "UPDATE produtos SET desc_produtos'"+mo.DescProduto+"', valor=" +numero +"WHERE codigo_produtos="+mo.CodProduto + "";
                MySqlCommand comandos = new MySqlCommand(alterar, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch(Exception ex) {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }
    }
}