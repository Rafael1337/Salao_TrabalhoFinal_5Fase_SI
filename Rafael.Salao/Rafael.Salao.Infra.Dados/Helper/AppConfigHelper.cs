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
            GetFirstFolder();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.AppendLine("<configuration>");
            sb.AppendLine("<appSettings>");
            sb.AppendLine("<add key = 'DataProvider' value = 'MySql.Data.MySqlClient' />");
            sb.AppendLine("<add key = 'DataProvider' value = 'System.Data.SqlClient' />");
            sb.AppendLine("<add key = 'ConnectionStringName' value = 'SqlServer_Teste' />");
            sb.AppendLine("</appSettings>");
            sb.AppendLine("<connectionStrings>");
            sb.AppendLine("<add name='SqlServer' connectionString='Server=${servidor};Database=${database};User Id=${usuario};Password=${senha}'  providerName='System.Data.SqlClient' />");
            sb.AppendLine("<add name='MySql' connectionString='Server=${servidor};Database=${database};Uid=${usuario};Pwd=${senha};Connect Timeout=30;' providerName='MySql.Data.MySqlClient' />");
            sb.AppendLine("</connectionStrings>");
            sb.AppendLine("</configuration>");
            File.WriteAllText("App.config", sb.ToString());
            SetValuesForAppConfig();
        }

        private void GetFirstFolder()
        {
            string first = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            string second = Directory.GetParent(first).ToString();
            first_folder = Directory.GetParent(second).ToString();
        }

        private void SetValuesForAppConfig()
        {
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Load(first_folder + "\\Rafael.Salao.WinApp\\bin\\Debug\\config\\databaseconfig.xml");

            XDocument appconfig = new XDocument();
            appconfig = XDocument.Load(@"App.config");

            string servidor = xdoc.FindElement("servidor").Value;
            string database = xdoc.FindElement("banco").Value;
            string usuario = xdoc.FindElement("usuario").Value;
            string senha = xdoc.FindElement("senha").Value;

            string newAppconfig;
            newAppconfig = TxtHelper.ReplacerFieldsInTXT("${servidor}", servidor, appconfig.ToString());
            newAppconfig = TxtHelper.ReplacerFieldsInTXT("${database}", database, newAppconfig);
            newAppconfig = TxtHelper.ReplacerFieldsInTXT("${usuario}", usuario, newAppconfig);
            newAppconfig = TxtHelper.ReplacerFieldsInTXT("${senha}", senha, newAppconfig);

            appconfig = XDocument.Parse(newAppconfig);
            appconfig.Save("App.config");

            MoveAppConfig();

        }

        public void MoveAppConfig()
        {
            try
            {
                File.Copy("App.config", String.Concat(first_folder + "\\Rafael.Salao.Infra.Dados.Testes\\", "App.config"));
            }
            catch (IOException)
            {

            }
        }
    }
}
