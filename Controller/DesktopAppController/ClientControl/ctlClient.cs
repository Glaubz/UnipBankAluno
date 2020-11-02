using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClientControl
{
    public class ctlClient
    {
        public bool Cadastro(string cpf, string nome, string rua, int nr_rua, double renda, string dt_nasc)
        {
            //Define uma string de conexão com o banco de dados
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankProf;Integrated Security=True";

            try
            {
                //Abre a conxexão
                SqlConn.Open();
                {
                    SqlCommand SqlCmd = new SqlCommand("sp_insertCliente", SqlConn);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlCmd.Parameters.AddWithValue("@SP_cpf", cpf);
                    SqlCmd.Parameters.AddWithValue("@SP_nome", nome);
                    SqlCmd.Parameters.AddWithValue("@SP_rua", rua);
                    SqlCmd.Parameters.AddWithValue("@SP_nr_rua", nr_rua);
                    SqlCmd.Parameters.AddWithValue("@SP_dt_nasc", dt_nasc);
                    SqlCmd.Parameters.AddWithValue("@SP_renda", renda);
                    SqlCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("O registro não pode ser salvo !! " + ex.Message);
                throw ex;
            }

            return true;
        }

        public DataTable Lista()
        {
            //Define uma string de conexão com o banco de dados
            SqlConnection SqlConn = new SqlConnection(); //Cria uma conexão com bd
            SqlConn.ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankProf;Integrated Security=True"; //Connection String do banco de dados para conectar ao projeto

            try
            {
                SqlConn.Open(); //Abre a conexão
                {
                    SqlCommand SqlCmd = new SqlCommand("Select * from cliente", SqlConn); //Cria um comando sql para trazer um resultado, precisa do parâmetro com a conexão do banco
                    SqlDataAdapter adapter = new SqlDataAdapter(); //O Adaptador prepara para buscar os dados e preencher um DataSet
                    adapter.SelectCommand = SqlCmd; //O adapter recebe o valor resultado do sql command que foi criado
                    DataTable dtbCliente = new DataTable(); //DataTable é um tipo DataSet menos genérico
                    adapter.Fill(dtbCliente); //Preenche o DataSet, DataTable no caso
                    return dtbCliente; //Retorna o valor da consulta
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable Busca(string cpf)
        {
            //Define uma string de conexão com o banco de dados
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = @"Data Source=PC-WORK\SQLEXPRESS;Initial Catalog=UnipBank;Integrated Security=True";

            try
            {
                //Abre a conxexão
                SqlConn.Open();
                {
                    SqlCommand SqlCmd = new SqlCommand("Select * from cliente where cpf = @cpf and status = 'A' ", SqlConn);
                    SqlCmd.Parameters.AddWithValue("@cpf", cpf);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCmd;
                    DataTable dtbCliente = new DataTable();
                    adapter.Fill(dtbCliente);
                    return dtbCliente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Exclui(string cpf)
        {
            //Define uma string de conexão com o banco de dados
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = @"Data Source=PC-WORK\SQLEXPRESS;Initial Catalog=UnipBank;Integrated Security=True";

            try
            {
                //Abre a conxexão
                SqlConn.Open();
                {
                    SqlCommand SqlCmd = new SqlCommand("Delete cliente where cpf = @cpf", SqlConn);
                    SqlCmd.Parameters.AddWithValue("@cpf", cpf);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCmd;
                    DataTable dtbCliente = new DataTable();
                    adapter.Fill(dtbCliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Atualiza(string cpf, string nome, string rua, int nr_rua, double renda, string dt_nasc)
        {
            //Define uma string de conexão com o banco de dados
            SqlConnection SqlConn = new SqlConnection();
            SqlConn.ConnectionString = @"Data Source=PC-WORK\SQLEXPRESS;Initial Catalog=UnipBank;Integrated Security=True";

            try
            {
                //Abre a conxexão
                SqlConn.Open();
                {
                    SqlCommand SqlCmd = new SqlCommand("update cliente set nome = @SP_nome, rua = @SP_rua, nr_rua = @SP_nr_rua, dt_nasc = @SP_dt_nasc, renda = @SP_renda where cpf = @SP_cpf", SqlConn);
                    SqlCmd.Parameters.AddWithValue("@SP_cpf", cpf);
                    SqlCmd.Parameters.AddWithValue("@SP_nome", nome);
                    SqlCmd.Parameters.AddWithValue("@SP_rua", rua);
                    SqlCmd.Parameters.AddWithValue("@SP_nr_rua", nr_rua);
                    SqlCmd.Parameters.AddWithValue("@SP_dt_nasc", dt_nasc);
                    SqlCmd.Parameters.AddWithValue("@SP_renda", renda);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCmd;
                    DataTable dtbCliente = new DataTable();
                    adapter.Fill(dtbCliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
