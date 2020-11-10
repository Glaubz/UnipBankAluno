using ClientModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClientControl
{
    public class ctlConta
    {
        string ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankAluno;Integrated Security=True";

        public decimal ValorEmConta(string usuario)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = ConnectionString;

            try
            {
                SqlConn.Open();
                {
                    SqlCommand SqlCom = new SqlCommand(@"SELECT * 
                                                        FROM conta co 
                                                        JOIN cliente cl ON cl.conta = co.numeroConta 
                                                        JOIN acesso ac ON ac.idAcesso = cl.idAcesso 
                                                        WHERE ac.usuario = @usuario", SqlConn);
                    //SqlCom.CommandType = CommandType.StoredProcedure;
                    SqlCom.Parameters.AddWithValue("@usuario", usuario);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCom;
                    DataTable saldo = new DataTable();
                    adapter.Fill(saldo);
                    return (decimal)saldo.Rows[0]["saldo"];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private DataTable ObterContaDoBD(string usuario)
        {
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = ConnectionString;

            try
            {
                SqlConn.Open();
                {
                    SqlCommand SqlCom = new SqlCommand("SELECT co.numeroConta, co.tipoConta, co.maxDinheiro, co.valorMensal, co.saldo " +
                                                            "FROM conta co " +
                                                            "JOIN cliente cl ON co.numeroConta = cl.conta " +
                                                            "JOIN acesso ac ON ac.idAcesso = cl.idAcesso " +
                                                            "WHERE ac.usuario = @Login", SqlConn);
                    SqlCom.Parameters.AddWithValue("@Login", usuario);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCom;
                    DataTable conta = new DataTable();
                    adapter.Fill(conta);
                    return conta;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                SqlConn.Close();
            }

        }

        public mdlConta ObterConta(string usuario)
        {
            DataTable contaDT = ObterContaDoBD(usuario);
            mdlConta conta = new mdlConta()
            {
                NumeroConta = contaDT.Rows[0]["numeroConta"].ToString(),
                TipoConta = Convert.ToInt32(contaDT.Rows[0]["tipoConta"]),
                MaxDinheiro = double.Parse(contaDT.Rows[0]["maxDinheiro"].ToString()),
                ValorMensal = double.Parse(contaDT.Rows[0]["valorMensal"].ToString()),
                Saldo = double.Parse(contaDT.Rows[0]["saldo"].ToString())
            };

            return conta;
        }

    }
}
