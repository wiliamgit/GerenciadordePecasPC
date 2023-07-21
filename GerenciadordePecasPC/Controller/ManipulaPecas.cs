using GerenciadordePecasPC.Model;
using System.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadordePecasPC.View;

namespace GerenciadordePecasPC.Controller
{
    internal class ManipulaPecas
    {
        public void/* <-- Não precisa colocar o return   */ CadPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectarbd()); 
            SqlCommand cmd = new SqlCommand("PcadasatrarPecas",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("pecas", Pecas.Peca); ;
                cmd.Parameters.AddWithValue("marcas",Pecas.Marca);
                cmd.Parameters.AddWithValue("capacidades",Pecas.Capacidade);

                SqlParameter nv = cmd.Parameters.Add("idPecas", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça cadastrada com  sucesso, Deseja cadastrar outra Peça?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaCadastrarPecas telaCadastrar = new TelaCadastrarPecas();
                    telaCadastrar.abrirCadastro();

                }
                else
                {
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void buscarpecaCod()
        {
           /*Conectar o banco dados em conexao do Model*/ SqlConnection cn = new SqlConnection(Conexao.Conectarbd());
           /* estanciar com a procedure pBuscarPecaCodigo*/ SqlCommand cmd = new SqlCommand("pBuscaPecaCodigo", cn);
           /* Conector com cn banco*/ cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("idPecas", Pecas.Codigo);
                /* abrir banco */cn.Open();
               /*ler os valores do cmd e inputar no banco*/ cmd.ExecuteNonQuery();

                var registro = cmd.ExecuteReader();

                if (registro.Read())
                {
                    Pecas.Codigo = Convert.ToInt32(registro["idPecas"]);
                    Pecas.Peca= (string)registro["pecas"];
                    Pecas.Marca = (string)registro["marcas"];
                    Pecas.Capacidade = (string)registro["capacidades"];
                }
                else
                {
                    Pecas.Codigo = 0;
                    Pecas.Peca = "";
                    Pecas.Marca = "";
                    Pecas.Capacidade = "";
                    MessageBox.Show("Peça naõ encontrada", "Pesquisa Código");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deletarPeca()
        {

            SqlConnection cn = new SqlConnection(Conexao.Conectarbd());
            SqlCommand cmd = new SqlCommand("pDeletarPecas", cn);
            /*Esse cmd é uma procedure*/cmd.CommandType = CommandType.StoredProcedure;

           /*Tentativa de resultado, erro com codigo Ex: 404 */ try
            {
                cmd.Parameters.AddWithValue("@idpecas", Pecas.Codigo);
                cmd.Parameters.AddWithValue("@pecas", Pecas.Codigo);
                cmd.Parameters.AddWithValue("@marcas", Pecas.Codigo);
                cmd.Parameters.AddWithValue("@capacidade", Pecas.Codigo);
                cn.Open();
                cmd.ExecuteReader();

                var resposta = MessageBox.Show("Peça deletada com  sucesso, Deseja Deleatar outra Peça?",
                 "Deleatrar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaCadastrarPecas telaCadastrar = new TelaCadastrarPecas();
                  
                }

                else
                {
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AleterarPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectarbd());
            SqlCommand cmd = new SqlCommand("pAlterarPecas", cn);
            /*Esse cmd é uma procedure*/
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                /* adicionar os parametros */ cmd.Parameters.AddWithValue("idPecas", Pecas.Codigo);
                cmd.Parameters.AddWithValue("Peca", Pecas.Codigo);
                cmd.Parameters.AddWithValue("Marca", Pecas.Codigo);
                cmd.Parameters.AddWithValue("Capacidade", Pecas.Codigo);
                cn.Open();
                cmd.ExecuteReader();
                var resposta = MessageBox.Show("Peça Alterada com  sucesso, Deseja alterar outra Peça?",
                "Deleatrar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                MessageBox.Show("Peça alterada com Sucesso.");
                Pecas.Codigo = 0;
                Pecas.Peca = "";
                Pecas.Marca = "";
                Pecas.Capacidade = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
   
}
