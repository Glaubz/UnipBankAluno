using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http;
using System.Text;
using ClientModel;

namespace ClientControl
{
    public class ctlSaque
    {
        string ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankAluno;Integrated Security=True";

        public decimal Saque(decimal valorSaque, string usuario)
        {
            SqlConnection SqlConn = new SqlConnection(ConnectionString);

            try
            {
                if(valorSaque < 0)
                    throw new Exception("O valor do saque nao pode ser negativo");

                ctlConta _ctlConta = new ctlConta();
                decimal saldoDisponivel = _ctlConta.ValorEmConta(usuario);
                if (valorSaque > saldoDisponivel)
                    throw new Exception("O valor de saque é maior que o saldo disponível");
                decimal novoSaldo = saldoDisponivel - valorSaque;

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

                string mensagem = "Feito saque de R$" + valorSaque;
                ctlExtrato _ctlExtrato = new ctlExtrato();
                _ctlExtrato.Logs(mensagem);

                return novoSaldo;
            }
            catch(Exception ex)
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
