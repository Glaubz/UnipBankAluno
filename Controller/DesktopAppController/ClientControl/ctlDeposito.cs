using System;
using System.Collections.Generic;
using System.Text;

namespace ClientControl
{
    public class ctlDeposito
    {
        string ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankAluno;Integrated Security=True";

        public void Depositar(decimal ValorSaldo)
        {
            SqlConnection SqlConn = new SqlConnection(ConnectionString);
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

        }

    }
}
