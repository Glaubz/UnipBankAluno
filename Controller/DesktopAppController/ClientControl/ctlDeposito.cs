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
                if(valorDeposito < 0)
                    throw new Exception("O valor de deposito nao pode ser negativo");

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

                string mensagem = "Feito deposito de R$" + valorDeposito;
                ctlExtrato _ctlExtrato = new ctlExtrato();
                _ctlExtrato.Logs(mensagem);

                return novoSaldo;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (message.Contains( @"Erro de estouro aritmético ao converter numeric no tipo de dados numeric"))
                    throw new Exception("O valor de deposito faz com que o saldo ultrapasse o limite");

                throw ex;
            }
            finally
            {
                SqlConn.Close();
            }

        }

    }
}
