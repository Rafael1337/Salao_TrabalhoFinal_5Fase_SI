using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Infra.Dados.Caixa
{
    public class CaixaDao
    {
        private static double saldo_adicionado;

        private static string init_caixa = "INSERT INTO TBCAIXA(SALDO, DATA_ATUAL) VALUES(0, CONVERT(date, SYSDATETIME()))";
        private static string _scriptInsercao = @"UPDATE TBCAIXA SET SALDO = (SELECT SALDO FROM TBCAIXA WHERE DATA_ATUAL = CONVERT (date, SYSDATETIME())) + " + saldo_adicionado;

        public void FirstTimeOpenInitCaixa(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand(init_caixa, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
