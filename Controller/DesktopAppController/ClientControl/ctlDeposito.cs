using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClientControl
{
    public class ctlDeposito
    {
        string ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankAluno;Integrated Security=True";

        public decimal Depositar(decimal valorDeposito, string usuario)
        {
            SqlConnection SqlConn = new SqlConnection(ConnectionString);
            try
            {
                ctlConta _ctlConta = new ctlConta();
                decimal saldoDisponivel = _ctlConta.ValorEmConta(usuario);

                decimal novoSaldo = valorDeposito + saldoDisponivel;

                if (SqlConn.State != ConnectionState.Open)
                    SqlConn.Open();
                SqlCommand SqlCmd = new SqlCommand(@"UPDATE co
                                                        SET co.saldo = @saldo
                                                        FROM cliente cl
                                                        JOIN acesso ac ON ac.idAcesso = cl.idAcesso
                                                        JOIN conta co ON co.numeroConta = cl.conta
                                                        WHERE ac.usuario = @usuario", SqlConn);
                SqlCmd.Parameters.AddWithValue("@saldo", novoSaldo);
                SqlCmd.Parameters.AddWithValue("@usuario", usuario);
                SqlCmd.ExecuteNonQuery();

                return novoSaldo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SqlConn.Close();
            }

        }

    }
}
