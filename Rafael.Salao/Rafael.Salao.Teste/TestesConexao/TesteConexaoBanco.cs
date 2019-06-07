using NUnit.Framework;
using System.IO;
using FluentAssertions;
using Rafael.Salao.Infra.Dados;
using System.Data.SqlClient;

namespace Rafael.Salao.Teste.TestesConexao
{
    /// <summary>
    /// Descrição resumida para TesteConexaoBanco
    /// </summary>
    [TestFixture]
    public class TesteConexaoBanco
    {
        [Test]
        public void Teste_Arquivo_ConnectionString_Existe()
        {
            bool resultado = false;
            if (File.Exists(@"config\databaseconnection.xml"))
            {
                resultado = true;
            }
            resultado.Should().BeTrue();
        }
        [Test]
        public void Teste_Conexao_Com_Banco_E_Valida()
        {
            DabaseConnection.ObterParametrosConnectionString();
            DabaseConnection.connection_created = new SqlConnection(DabaseConnection.connection_string);

        }
    }
}
