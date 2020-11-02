using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClientControl
{
    public class ctlAcesso
    {
        public DataTable UsuarioAcesso(string nome)
        {
            //Manipulando dados de um BD Sql Server

            SqlConnection SqlConnection = new SqlConnection(); //Cria uma conexão com bd
            SqlConnection.ConnectionString = @"Data Source=DESKTOP-G3S4QVO\SQLEXPRESS;Initial Catalog=UnipBankAluno;Integrated Security=True"; //Connection String do banco de dados para conectar ao projeto

            try
            {
                SqlConnection.Open(); //Abre a conexão
                {
                    SqlCommand SqlCom = new SqlCommand("SELECT usuario, senha FROM acesso WHERE usuario = @usuario", SqlConnection); //Cria um comando sql para trazer um resultado, precisa do parâmetro com a conexão do banco
                    SqlCom.Parameters.AddWithValue("@usuario", nome); //Coloca um valor à uma variável sql
                    SqlDataAdapter adapter = new SqlDataAdapter(); //O Adaptador prepara para buscar os dados e preencher um DataSet 
                    adapter.SelectCommand = SqlCom; //O adapter recebe o valor resultado do sql command que foi criado
                    DataTable dtbCliente = new DataTable(); //DataTable é um tipo DataSet menos genérico
                    adapter.Fill(dtbCliente); //Preenche o DataSet, DataTable no caso
                    return dtbCliente; //Retorna o valor da consulta
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
