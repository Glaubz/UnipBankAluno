using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace ClientControl
{
    public class ctlTransferencia
    {
        string ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankAluno;Integrated Security=True";

        public void Transferir(decimal valorTransferencia, string usuarioOrigem, string usuarioDestino)
        {
            SqlConnection SqlConn = new SqlConnection(ConnectionString);

            try
            {
                if (valorTransferencia < 0)
                    throw new Exception("O valor de transferencia nao pode ser negativo");

                Dictionary<int, string> existeDestinatario = ValidaDestinatario(usuarioDestino);
                if (existeDestinatario.TryGetValue(0, out string mensagem))
                {
                    throw new Exception("Destinatario nao existe no banco");
                }

                ctlConta _ctlConta = new ctlConta();

                decimal saldoOrigem = _ctlConta.ValorEmConta(usuarioOrigem);
                if (valorTransferencia > saldoOrigem) //Se transferir um valor maior que o disponivel em conta da excecao
                    throw new Exception("O valor de transferencia é maior que o saldo disponível");
                decimal novoSaldo = saldoOrigem - valorTransferencia;

                decimal novoSaldoDestino = _ctlConta.ValorEmConta(usuarioDestino) + valorTransferencia;

                ctlSaque _ctlSaque = new ctlSaque();
                _ctlSaque.Saque(valorTransferencia, usuarioOrigem); //Para aproveitar codigo e subtrair do saldo

                if (SqlConn.State != ConnectionState.Open)
                    SqlConn.Open();

                SqlCommand SqlCmd = new SqlCommand(@"UPDATE co
                                                        SET co.saldo = @SaldoDestino
                                                        FROM cliente cl
                                                        JOIN acesso ac ON ac.idAcesso = cl.idAcesso
                                                        JOIN conta co ON co.numeroConta = cl.conta
                                                        WHERE ac.usuario = @UsuarioDestino", SqlConn);
                SqlCmd.Parameters.AddWithValue("@SaldoDestino", novoSaldoDestino);
                SqlCmd.Parameters.AddWithValue("@UsuarioDestino", usuarioDestino);
                SqlCmd.ExecuteNonQuery();

                string msg = "Feito transferencia de R$" + valorTransferencia;
                ctlExtrato _ctlExtrato = new ctlExtrato();
                _ctlExtrato.Logs(msg);
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

        private Dictionary<int, string> ValidaDestinatario(string destinatario)
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            SqlConnection SqlConn = new SqlConnection(ConnectionString);

            try
            {
                if (SqlConn.State != ConnectionState.Open)
                    SqlConn.Open();

                SqlCommand SqlCom = new SqlCommand(@"SELECT ac.usuario, cl.nome 
                                                        FROM acesso ac 
                                                        JOIN cliente cl ON cl.idAcesso = ac.idAcesso
                                                        WHERE ac.usuario = @destinatario
                                                        OR cl.nome = @destinatario", SqlConn);
                SqlCom.Parameters.AddWithValue("@destinatario", destinatario);

                SqlDataReader reader = SqlCom.ExecuteReader();
                if (reader.Read())
                {
                    retorno.Add(1, "Nome existe no banco");
                    return retorno;
                }
                else
                {
                    retorno.Add(0, "Nome nao existe no banco");
                    return retorno;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

    }
}
