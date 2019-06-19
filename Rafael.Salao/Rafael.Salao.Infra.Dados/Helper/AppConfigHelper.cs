using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rafael.Salao.Infra.Dados.Helper
{
    public class AppConfigHelper
    {
        string first_folder;
        public void CreateAppSettings()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.AppendLine("<configuration>");
            sb.AppendLine("<appSettings>");
            sb.AppendLine("<add key = 'DataProvider' value = 'MySql.Data.MySqlClient' />");
            sb.AppendLine("<add key = 'DataProvider' value = 'System.Data.SqlClient' />");
            sb.AppendLine("<add key = 'ConnectionStringName' value = 'SqlServer_Teste' />");
            sb.AppendLine("</appSettings>");
            sb.AppendLine("<connectionStrings>");
            sb.AppendLine("<add name='SqlServer' connectionString='Server=localhost;Database=PizzariaDB_Teste;User Id=sa;Password=Password_123'  providerName='System.Data.SqlClient' />");
            sb.AppendLine("<add name='MySql' connectionString='Server=localhost;Database=pizzariadb_teste;Uid=root;Pwd=P@ssw0rd;Connect Timeout=30;' providerName='MySql.Data.MySqlClient' />");
            sb.AppendLine("</connectionStrings>");
            sb.AppendLine("</configuration>");
            File.WriteAllText("App.config", sb.ToString());
            MoveAppConfig();
        }
        public void MoveAppConfig()
        {
            string first = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            string second = Directory.GetParent(first).ToString();
            first_folder = Directory.GetParent(second).ToString();
            File.Copy("App.config", String.Concat(first_folder + "\\Rafael.Salao.Infra.Dados.Testes\\", "App.config"));
        }

        public void VerifyProvider(XDocument appdoc)
        {
            if (appdoc.FindElement("add").FindAttribute("providerName").Value.Equals("System.Data.SqlClient") == true)
                LoadSqlServerProvider();

            if (appdoc.FindElement("add").FindAttribute("providerName").Value.Equals("MySql.Data.MySqlClient") == true)
                LoadMysqlProvider();
        }

        private void LoadMysqlProvider()
        {
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Load(first_folder + "\\Rafael.Salao.WinApp\\bin\\Debug\\config");
            string provider = "MySql.Data.MySqlClient";

            string servidor = xdoc.FindElement("servidor").Value;
            string database = xdoc.FindElement("banco").Value;
            string usuario = xdoc.FindElement("usuario").Value;
            string senha = xdoc.FindElement("senha").Value;

            string connectionStringApp = "Server=" + servidor + ";Database=" + database + ";Uid=" + usuario + ";Pwd=" + senha + ";" + "Connect Timeout=30";
            ConstructAppConfig(connectionStringApp, provider);
        }

        private void LoadSqlServerProvider()
        {
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Load(first_folder + "\\Rafael.Salao.WinApp\\bin\\Debug\\config");
            string provider = "System.Data.SqlClient";

            string servidor = xdoc.FindElement("servidor").Value;
            string database = xdoc.FindElement("banco").Value;
            string usuario = xdoc.FindElement("usuario").Value;
            string senha = xdoc.FindElement("senha").Value;

            string connectionStringApp = "Server=" + servidor + ";Database=" + database + ";User Id=" + usuario + ";Password=" + senha + "";
            ConstructAppConfig(connectionStringApp, provider);
        }

        public void ConstructAppConfig(string connectionString, string provider)
        {
            XDocument appdoc = new XDocument();
            appdoc = XDocument.Load(first_folder + "\\Rafael.Salao.Infra.Dados.Testes\\App.config");


            ConstructSqlServer(appdoc, connectionString, provider);
        }

        private void ConstructSqlServer(XDocument appdoc, string connectionStringApp, string provider)
        {
            if (appdoc.FindElement("add").FindAttribute(provider).Value.Equals("System.Data.SqlClient"))
            appdoc.FindElement("add").FindAttribute("connectionString").Value.Replace(appdoc.FindElement("add").FindAttribute("connectionString").Value, connectionStringApp);
        }
        private void ConstructMySql(XDocument appdoc, string connectionStringApp, string provider)
        {
            if (appdoc.FindElement("add").FindAttribute(provider).Value.Equals("MySql.Data.MySqlClient"))
                appdoc.FindElement("add").FindAttribute("connectionString").Value.Replace(appdoc.FindElement("add").FindAttribute("connectionString").Value, connectionStringApp);
        }
    }
}
