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
        private static int have_register = 0;
        private static string init_caixa = @"INSERT INTO TBCAIXA(SALDO, DATA_ATUAL) VALUES(0, CONVERT(date, SYSDATETIME()))";
        private static string _get_register = @"SELECT COUNT(*) FROM TBCAIXA";

        private static string _get_actual_saldo = "SELECT SALDO FROM TBCAIXA WHERE DIA_FECHADO is NULL";
        public void FirstTimeOpenInitCaixa(SqlConnection connection)
        {
            VerifyContainsData(connection);
            if (have_register == 0)
            {
                SqlCommand cmd = new SqlCommand(init_caixa, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void VerifyContainsData(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand(_get_register, connection);
            try
            {
                connection.Open();
                have_register = (Int32)cmd.ExecuteScalar();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
            }
        }

        public int EscreveSaldoAtual(SqlConnection connection)
        {
            int saldo = 0;
            SqlCommand cmd = new SqlCommand(_get_actual_saldo, connection);
            try
            {
                connection.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        saldo += Convert.ToInt32((read["SALDO"].ToString()));
                    }
                }
                        connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
            }

            return saldo;
        }

        public void AdicionarSaldo(double valor, SqlConnection connection)
        {
           string _scriptInsercao = @"UPDATE TBCAIXA SET SALDO = (SELECT SALDO FROM TBCAIXA WHERE DATA_ATUAL = CONVERT (date, SYSDATETIME())) + " + valor;

            SqlCommand cmd = new SqlCommand(_scriptInsercao, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
