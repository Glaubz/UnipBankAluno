using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClientControl
{
    public class ctlAcesso
    {
        public Dictionary<int, string> UsuarioAcesso(string nome)
        {
            //Manipulando dados de um BD Sql Server

            Dictionary<int, string> retorno = new Dictionary<int, string>();
            SqlConnection SqlConnection = new SqlConnection();
            SqlConnection.ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankAluno;Integrated Security=True";

            try
            {
                SqlConnection.Open();
                {
                    SqlCommand SqlCom = new SqlCommand("SELECT usuario, senha FROM acesso WHERE usuario = @usuario", SqlConnection);
                    SqlCom.Parameters.AddWithValue("@usuario", nome); //Coloca um valor à uma variável sql

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
                SqlConnection.Close();
            }

        }


    }
}
