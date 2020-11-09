using ClientModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClientControl
{
    public class ctlAcesso
    {
        public mdlClient Cliente { get; set; }

        string ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankAluno;Integrated Security=True";

        public Dictionary<int, string> UsuarioAcesso(string nome)
        {
            //Manipulando dados de um BD Sql Server

            Dictionary<int, string> retorno = new Dictionary<int, string>();
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = ConnectionString;

            try
            {
                SqlConn.Open();
                {
                    SqlCommand SqlCom = new SqlCommand("SELECT usuario, senha FROM acesso WHERE usuario = @usuario", SqlConn);
                    SqlCom.Parameters.AddWithValue("@usuario", nome); 

                    SqlDataReader reader = SqlCom.ExecuteReader();
                    if (reader.Read())
                    {
                        retorno.Add(1, "Conexão com o Banco Realizada com sucesso!");
                        return retorno;
                    }
                    else
                    {
                        retorno.Add(0, "Usuário ou senha incorretos!");
                        return retorno;
                    }
                    
                }
            }
            catch (Exception e)
            {
                retorno.Add(0, e.Message);
                return retorno;
            }
            finally
            {
                SqlConn.Close();
            }

        }

        public DataTable InfoUsuario(string login)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = ConnectionString;

            try
            {
                SqlConn.Open();
                {
                    SqlCommand SqlCom = new SqlCommand("SELECT cl.cpf, cl.nome, cl.nr_rua, cl.rua, cl.renda, cl.dt_nasc, " +
                                                                "ac.idAcesso, ac.usuario, " +
                                                                "co.numeroConta, co.tipoConta, co.valorMensal, co.maxDinheiro, co.saldo " +
                                                                "FROM cliente cl " +
                                                                "JOIN acesso ac ON ac.idAcesso = cl.idAcesso " +
                                                                "JOIN conta co ON co.numeroConta = cl.conta " +
                                                                "WHERE ac.usuario like @Login", SqlConn);
                    SqlCom.Parameters.AddWithValue("@Login", login);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCom;
                    DataTable usuario = new DataTable();
                    adapter.Fill(usuario);
                    return usuario;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SqlConn.Close();
            }

        }

        public void ConstructClient(mdlAcesso _mdlAcesso)
        {
            ctlAcesso _ctlAcesso = new ctlAcesso();
            DataTable usuario = _ctlAcesso.InfoUsuario(_mdlAcesso.Usuario);
            ctlConta _ctlConta = new ctlConta();
            mdlClient cliente = new mdlClient
            {
                Acesso = _mdlAcesso,
                Conta = _ctlConta.ObterConta(_mdlAcesso.Usuario), //ObtemConta
                cpf = usuario.Rows[0]["cpf"].ToString(),
                nome = usuario.Rows[0]["nome"].ToString(),
                nr_rua = Convert.ToInt32(usuario.Rows[0]["nr_rua"]),
                rua = usuario.Rows[0]["rua"].ToString(),
                renda = double.Parse(usuario.Rows[0]["renda"].ToString()),
                dt_nasc = usuario.Rows[0]["dt_nasc"].ToString(),
            };
            Cliente = cliente;
        }

        public mdlClient GetCliente()
        {
            return Cliente;
        }

    }
}
