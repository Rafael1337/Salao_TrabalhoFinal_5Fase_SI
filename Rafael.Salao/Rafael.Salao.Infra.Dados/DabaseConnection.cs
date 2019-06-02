﻿

using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
using Rafael.Salao.Infra.Dados.Helper;
using Rafael.Salao.WinApp.Banco;

namespace Rafael.Salao.Infra.Dados
{
    public class DabaseConnection
    {
        public static SqlConnection connection_created;
        public static string connection_string = "";

        public static void CreateConnection()
        {
            GetConnectionString();
            connection_created = new SqlConnection(connection_string);
            try
            {
                connection_created.Open();
                CreateTable(); // auto executar script de tabelas da solução.
                connection_created.Close();
            }
            catch (SqlException)
            {
                CreateConnection();
            }
        }

        private static void GetConnectionString()
        {
            if (File.Exists(@"databaseconnection.xml"))
            {
                CriaNovoArquivoDeConexao();
            }
            else
            {
                try
                {
                    CreateDatabase();
                }
                catch (SqlException) { }
                Tela_Conexao_Banco TCB = new Tela_Conexao_Banco(); //Chamar nova tela para conexao de banco
                TCB.ShowDialog();
            }
        }

        private static void CriaNovoArquivoDeConexao()
        {
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Load(@"databaseconnection.xml");
            connection_string = @"Data Source=" + xdoc.FindElement("server").Value + ";Initial Catalog=" + xdoc.FindElement("database").Value + ";User ID=" + xdoc.FindElement("user").Value + ";Password=" + xdoc.FindElement("password").Value + ";";
        }

        private static void CreateDatabase()
        {
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

            SqlCommand sqlexecute = new SqlCommand("CREATE DATABASE SALAO_DATABASE;", myConn);
            myConn.Open();
            sqlexecute.ExecuteNonQuery();
            myConn.Close();
        }
    }
}
