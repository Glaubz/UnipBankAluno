using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClientControl
{
    public class ctlAcesso
    {
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
                    SqlCommand SqlCom = new SqlCommand("SP_InsertInCode", SqlConn);
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

    }
}
