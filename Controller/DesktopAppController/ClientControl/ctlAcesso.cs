using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClientControl
{
    public class ctlAcesso
    {
        public string UsuarioAcesso(string nome)
        {
            //Manipulando dados de um BD Sql Server

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
                        return reader.GetSqlValue(1).ToString();
                    }
                    else
                    {
                        return "";
                    }
                    
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SqlConnection.Close();
            }

        }


    }
}
