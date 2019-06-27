using Rafael.Salao.Infra.Dados.Helper;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Rafael.Salao.Infra.Dados
{
    public class DabaseConnection
    {
        public static SqlConnection connection_created;
        public string connection_string = "";
        public XDocument xdoc = new XDocument();
        public AppConfigHelper AppCHelper = new AppConfigHelper();

        public void InitializeConnection()
        {
            GetConnectionString();
            connection_created = new SqlConnection(connection_string);

            try
            {
                connection_created.Open();
                VerifyExistingTables();
                connection_created.Close();
            }
            catch (SqlException)
            {
                if (CheckDatabaseExists(connection_string, "SALAO_DATABASE") == false)
                {
                    CreateDatabase();
                }
                else
                {
                    MessageBox.Show("Não foi possivel conectar com o banco de dados, verifique se o servior do banco está funcionando corretamente ou sua rede está corretamente configurada.");
                }
            }
        }

        private void VerifyExistingTables()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id FROM TBFUNCIONARIO", connection_created);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CreateTables();
            }
        }

        private void CreateTables()
        {
            string script = File.ReadAllText(@"Scripts\scripts.sql");
            using (SqlCommand cmd = new SqlCommand(script, connection_created))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public bool GetConnectionString()
        {
            if (File.Exists(@"config\databaseconfig.xml"))
            {
                ObterParametrosConnectionString();
                if (CheckDatabaseExists(connection_string, xdoc.FindElement("banco").Value) == false)
                    CreateDatabase();
            }
            else
            {
                try
                {
                    CreateDatabase();
                    return true;
                }
                catch (SqlException){
                    return false;
                }
            }
            return true;
        }

        private bool CheckDatabaseExists(string connection_string, string value)
        {
            connection_created = new SqlConnection(connection_string);
            SqlCommand checkdatabase = new SqlCommand("use SALAO_DATABASE", connection_created);
            try
            {
                connection_created.Open();
                checkdatabase.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                connection_created.Close();
                return false;
            }
            connection_created.Close();
            return true;
        }

        public void CreateConfigDatabaseFile(string servidor, string banco, string usuario, string senha)
        {
            XDocument xdoc = new XDocument();
            string connectionstring = "<database-config><servidor>" + servidor + "</servidor>\n<banco>" + banco + "</banco>\n<usuario>" + usuario + "</usuario>\n <senha>" + senha + "</senha></database-config>";
            xdoc = XDocument.Parse(connectionstring);
            File.WriteAllText(@"config\databaseconfig.xml", xdoc.ToString());
            AppCHelper.CreateAppSettings();

            ObterParametrosConnectionString();
            if (CheckDatabaseExists(connection_string, banco) == false)
                CreateDatabase();
        }

        public void ObterParametrosConnectionString()
        {
            xdoc = XDocument.Load(@"config\databaseconfig.xml");
            connection_string = @"Data Source=" + xdoc.FindElement("servidor").Value + ";Initial Catalog=" + xdoc.FindElement("banco").Value + ";User ID=" + xdoc.FindElement("usuario").Value + ";Password=" + xdoc.FindElement("senha").Value + ";";
        }

        private bool CreateDatabase()
        {
            try
            {
                xdoc = XDocument.Load(@"config\databaseconfig.xml");
                SqlConnection myConn = new SqlConnection("Server="+xdoc.FindElement("servidor").Value+";Integrated security=SSPI;database=master");
                SqlCommand sqlexecute = new SqlCommand("CREATE DATABASE SALAO_DATABASE;", myConn);
                myConn.Open();
                sqlexecute.ExecuteNonQuery();
                myConn.Close();
                return true;
            }
            catch (SqlException)
            {
                return true;
            }
        }
    }
}
