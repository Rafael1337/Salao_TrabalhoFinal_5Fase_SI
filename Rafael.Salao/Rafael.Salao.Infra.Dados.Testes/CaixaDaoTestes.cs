using NUnit.Framework;
using Rafael.Salao.Infra.Dados.Caixa;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Infra.Dados.Testes
{
    [TestFixture]
    public class CaixaDaoTestes
    {
        public CaixaDao _caixaDao;

        [SetUp]
        public void Inicializar()
        {
            _caixaDao = new CaixaDao();
            LimpaBanco();
        }

        [Test]
        public void Testa_Inicializacao_do_Caixa()
        {
                string connectionString = "Server=172.31.40.23;Database=SALAO_DATABASE;User Id=sa;Password=p@ssw0rd";
                SqlConnection connection = new SqlConnection(connectionString);
                _caixaDao.FirstTimeOpenInitCaixa(connection);

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TBCAIXA", connection);
                connection.Open();
                 int register = (Int32)command.ExecuteScalar();
                connection.Close();
                int esperado = 1;

            Assert.AreEqual(esperado, register);
        }

        private void LimpaBanco()
        {
            string connectionString = "Server=172.31.40.23;Database=SALAO_DATABASE;User Id=sa;Password=p@ssw0rd";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM TBCAIXA", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
