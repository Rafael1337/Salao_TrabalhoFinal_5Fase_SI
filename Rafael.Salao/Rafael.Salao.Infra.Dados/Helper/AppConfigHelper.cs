using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Infra.Dados.Helper
{
    public class AppConfigHelper
    {
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
            sb.AppendLine("<add name = 'SqlServer_Teste' connectionString = 'Server=localhost;Database=PizzariaDB_Teste;User Id=sa; Password=Password_123'  providerName = 'System.Data.SqlClient' />");
            sb.AppendLine("<add name = 'MySql_Teste' connectionString = 'Server=localhost;Database=pizzariadb_teste;Uid=root;Pwd=P@ssw0rd;Connect Timeout=30;' providerName = 'MySql.Data.MySqlClient' />");
            sb.AppendLine("</connectionStrings>");
            sb.AppendLine("</configuration>");
            File.WriteAllText("App.config", sb.ToString());
            MoveAppConfig();
        }
        public void MoveAppConfig()
        {
            string first = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            string second = Directory.GetParent(first).ToString();
            string last = Directory.GetParent(second).ToString();
            File.Copy("App.config", String.Concat(last+ "\\Rafael.Salao.Infra.Dados.Testes\\", "App.config"));
        }
    }
}
