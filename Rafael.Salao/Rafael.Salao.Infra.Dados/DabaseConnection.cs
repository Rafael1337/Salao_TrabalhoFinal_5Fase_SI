

using System;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
using Rafael.Salao.Infra.Dados.Helper;

namespace Rafael.Salao.Infra.Dados
{
    public class DabaseConnection
    {
        public SqlConnection connection_created;
        public string connection_string = "";
        public bool connection_valid;

        public void InitializeConnection()
        {
            connection_valid = GetConnectionString();
                if (connection_valid == false)
                return;

            connection_created = new SqlConnection(connection_string);
            try
            {
                connection_created.Open();
                CreateTables(); // auto executar script de tabelas da solução.
                connection_created.Close();
            }
            catch (SqlException)
            {
                InitializeConnection();
            }
        }

        private void CreateTables()
        {
            string script = File.ReadAllText(@"Rafael.Salao.Infra.Dados\Scripts\scripts salao.sql");
            using (SqlCommand cmd = new SqlCommand(script, connection_created))
            {
                connection_created.Open();
                cmd.ExecuteNonQuery();
                connection_created.Close();
            }
        }

        private bool GetConnectionString()
        {
            if (!Directory.Exists(@"config"))
                Directory.CreateDirectory(@"config");

            if (File.Exists(@"config\databaseconnection.xml"))
            {
                ObterParametrosConnectionString();
            }
            else
            {
                try
                {
                    CreateDatabase();
                }
                catch (SqlException) {
                    return false;
                }
            }
            return true;
        }

        private void ObterParametrosConnectionString()
        {
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Load(@"config\databaseconnection.xml");
            connection_string = @"Data Source=" + xdoc.FindElement("servidor").Value + ";Initial Catalog=" + xdoc.FindElement("banco").Value + ";User ID=" + xdoc.FindElement("usuario").Value + ";Password=" + xdoc.FindElement("senha").Value + ";";
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
