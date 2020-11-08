using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http;
using System.Text;

namespace ClientControl
{
    public class ctlSaque
    {
        string ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankAluno;Integrated Security=True";

        public DataSet ValorEmConta(string numConta)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = ConnectionString;

            try
            {
                SqlConn.Open();
                {
                    SqlCommand SqlCom = new SqlCommand("SELECT saldo FROM conta WHERE numeroConta = @numConta", SqlConn);
                    SqlCom.CommandType = CommandType.StoredProcedure;
                    SqlCom.Parameters.AddWithValue("@numConta", numConta);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCom;
                    DataSet saldo = new DataSet();
                    adapter.Fill(saldo);
                    return saldo;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
