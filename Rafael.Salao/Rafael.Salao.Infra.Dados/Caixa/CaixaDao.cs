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
            else
            {
                bool get_new_data_box = VerificaSeDataAtualEDiferenteDeExistente(connection);
                if(get_new_data_box == true)
                {
                    SqlCommand cmd_caixa = new SqlCommand("INSERT INTO TBCAIXA(SALDO, DATA_ATUAL) VALUES(0, CONVERT(date, SYSDATETIME()))", connection);
                    connection.Open();
                    cmd_caixa.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public bool VerificaSeDataAtualEDiferenteDeExistente(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TBCAIXA WHERE DATA_ATUAL = CONVERT (date, SYSDATETIME())", connection);
                connection.Open();
                int contain_date = (Int32)cmd.ExecuteScalar();
                connection.Close();
                if(contain_date > 1)
                {
                    return true;

                }
                    return false;
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

        public void FecharCaixa()
        {
            string _scriptfechamento = @"UPDATE TBCAIXA SET DIA_FECHADO = 1 where DATA_ATUAL = CONVERT (date, SYSDATETIME())";
            SqlCommand command = new SqlCommand(_scriptfechamento, DabaseConnection.connection_created);
            DabaseConnection.connection_created.Open();
            command.ExecuteNonQuery();
            DabaseConnection.connection_created.Close();


        }
    }
}
