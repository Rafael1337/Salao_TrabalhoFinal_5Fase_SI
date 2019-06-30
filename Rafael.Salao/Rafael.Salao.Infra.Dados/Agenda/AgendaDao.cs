﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Rafael.Salao.Infra.Dados.Agenda
{
    public class AgendaDao
    {
        private const string _scriptInsercao = @"INSERT INTO TBAGENDA
           ([HORARIO]
           ,[DATA]
           ,[NOME_CLIENTE]
           ,[IDFUNCIONARIO]
           ,[IDSERVICO])
     VALUES
           ({0}HORARIO,
           {0}DATA,
           {0}NOME_CLIENTE,
           {0}IDFUNCIONARIO,
           {0}IDSERVICO)";

        private const string _scriptRemocao = @"DELETE FROM TBAGENDA WHERE ID = {0}ID";

        private const string _scriptUpdate = @"UPDATE SALAO_DATABASE TBAGENDA SET HORARIO = {0}HORARIO,
        ,[NOME_CLIENTE] = {0}NOME_CLIENTE
        ,[IDFUNCIONARIO] = {0}IDFUNCIONARIO
        ,[IDSERVICO] = {0}IDSERVICO
        ,[DATA] = {0}DATA
        WHERE ID = {0}ID";


        private const string _scriptBuscaPorId =
            @"SELECT [Id]
                  ,[HORARIO]
                  ,[NOME_CLIENTE]
                  ,[IDFUNCIONARIO]
                  ,[IDSERVICO]
                  ,[DATA]
              FROM [dbo].[TBAGENDA]
              WHERE [Id] = {0}Id";

        private const string _scriptExibir = @"SELECT [ID]
        ,[HORARIO]
        ,[NOME_CLIENTE]
        ,[IDFUNCIONARIO]
        ,[IDSERVICO]
        ,[DATA]
        FROM [TBAGENDA]";

        public int Adicionar(Dominio.Agenda novoRegistroAgenda)
        {
            return Db.Insert(_scriptInsercao, BuscarParametros(novoRegistroAgenda));
        }

        public IList<Dominio.Agenda> BuscarTodos()
        {
            return Db.GetAll(_scriptExibir, ConverterAgenda);
        }

        public Dominio.Agenda BuscarPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "Id", id } };

            return Db.Get(_scriptBuscaPorId, ConverterAgenda, parms);
        }

        public void Editar(Dominio.Agenda agenda)
        {
            Db.Update(_scriptUpdate, BuscarParametros(agenda));
        }

        public void Deletar(int id)
        {
            var parms = new Dictionary<string, object> { { "Id", id } };

            Db.Delete(_scriptRemocao, parms);
        }

        public int GetFuncionarioData(string NomeFuncionario)
        {
           string _script_get_funcionarioId = @"SELECT ID FROM TBFUNCIONARIO WHERE NOME = @name";
            int idfuncionario = 0;
            SqlCommand cmd = new SqlCommand(_script_get_funcionarioId, DabaseConnection.connection_created);
            cmd.Parameters.AddWithValue("@name", NomeFuncionario);
            DabaseConnection.connection_created.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        idfuncionario = Convert.ToInt32((read["ID"].ToString()));
                    }
                }
                DabaseConnection.connection_created.Close();

            return idfuncionario;
        }

        public int GetServicoData(string tipoServico)
        {
            string _script_get_servicoId = @"SELECT ID FROM TBSERVICO WHERE TIPO = @tiposervico";
            int idservico = 0;
            SqlCommand cmd = new SqlCommand(_script_get_servicoId, DabaseConnection.connection_created);
            cmd.Parameters.AddWithValue("@tiposervico", tipoServico);

            DabaseConnection.connection_created.Open();
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    idservico = Convert.ToInt32((read["ID"].ToString()));
                }
            }
            DabaseConnection.connection_created.Close();

            return idservico;
        }

        #region Metódos Privados - Conversor e Manipulador de Parametros

        private Dominio.Agenda ConverterAgenda(IDataReader reader)
        {
            Dominio.Agenda agenda = new Dominio.Agenda();
            agenda.Id = Convert.ToInt32(reader["ID"]);
            agenda.Nome_cliente = Convert.ToString(reader["NOME_CLIENTE"]);
            agenda.Data = Convert.ToString(reader["DATA"]);
            agenda.Horario = Convert.ToString(reader["HORARIO"]);
            agenda.Idfuncionario = Convert.ToInt32(reader["IDFUNCIONARIO"]);
            agenda.IdServico = Convert.ToInt32(reader["IDSERVICO"]);

            return agenda;
        }

        private Dictionary<string, object> BuscarParametros(Dominio.Agenda agenda)
        {
            return new Dictionary<string, object>
            {
                {"ID",agenda.Id},
                {"NOME_CLIENTE",agenda.Nome_cliente},
                {"DATA",agenda.Data},
                {"HORARIO",agenda.Horario },
                {"IDFUNCIONARIO",agenda.Idfuncionario},
                {"IDSERVICO",agenda.IdServico},
            };
        }

        #endregion
    }
}
