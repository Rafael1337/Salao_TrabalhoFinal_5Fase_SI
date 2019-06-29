using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Rafael.Salao.Dominio;

namespace Rafael.Salao.Infra.Dados.Servicos
{
    public class ServicosDao
    {
        public void PopulateCabelo()
        {
            string script_insert_cabelo = @"INSERT INTO TBSERVICO(TIPO, VALOR)VALUES('PROGRESSIVA', 50);INSERT INTO TBCABELO(TIPO, VALOR)VALUES('MECHA', 30);INSERT INTO TBCABELO(TIPO, VALOR)VALUES('ESCOVA', 30);INSERT INTO TBCABELO(TIPO, VALOR)VALUES('HIDRATACAO', 50);";
            SqlCommand command_insert_cabelo = new SqlCommand(script_insert_cabelo, DabaseConnection.connection_created);
            DabaseConnection.connection_created.Open();
            command_insert_cabelo.ExecuteNonQuery();
            DabaseConnection.connection_created.Close();
        }
        public void PopulateUnha()
        {
            string script_insert_unha = @"INSERT INTO TBSERVICO(TIPO, VALOR)VALUES('PROGRESSIVA', 50);INSERT INTO TBCABELO(TIPO, VALOR)VALUES('MECHA', 30);INSERT INTO TBCABELO(TIPO, VALOR)VALUES('ESCOVA', 30);";
            SqlCommand command_insert_unha = new SqlCommand(script_insert_unha, DabaseConnection.connection_created);
            DabaseConnection.connection_created.Open();
            command_insert_unha.ExecuteNonQuery();
            DabaseConnection.connection_created.Close();
        }
        public void PopulateDepilacao()
        {
            string script_insert_depilacao = @"INSERT INTO TBSERVICO(TIPO, VALOR)VALUES('VIRILIA', 50);INSERT INTO TBDEPILACAO(TIPO, VALOR)VALUES('MEIA PERNA', 30);INSERT INTO TBDEPILACAO(TIPO, VALOR)VALUES('COXA', 30);INSERT INTO TBDEPILACAO(TIPO, VALOR)VALUES('BUÇO', 50)INSERT INTO TBDEPILACAO(TIPO, VALOR)VALUES('AXILA', 50);";
            SqlCommand command_insert_depilacao = new SqlCommand(script_insert_depilacao, DabaseConnection.connection_created);
            DabaseConnection.connection_created.Open();
            command_insert_depilacao.ExecuteNonQuery();
            DabaseConnection.connection_created.Close();
        }

        public void VerifyAlredyExistServices()
        {
            if(VerifyServico() == true)
            {
                return;
            }
            else
            {
                PopulateCabelo();
                PopulateUnha();
                PopulateDepilacao();
            }
        }
        public bool VerifyServico()
        {
            string verify_data_cabelo = "SELECT COUNT(*) FROM TBSERVICO";
            SqlCommand verify_cabelo = new SqlCommand(verify_data_cabelo, DabaseConnection.connection_created);
            DabaseConnection.connection_created.Open();
            int contain_date = (Int32)verify_cabelo.ExecuteScalar();
            DabaseConnection.connection_created.Close();
            if (contain_date > 1)
            {
                return true;

            }
            return false;
        }
    }
}
