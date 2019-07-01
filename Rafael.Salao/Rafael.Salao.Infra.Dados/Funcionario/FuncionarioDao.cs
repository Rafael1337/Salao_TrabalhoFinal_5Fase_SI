using Rafael.Salao.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Rafael.Salao.Infra.Dados.Funcionario
{
    public class FuncionarioDao
    {
        private const string _scriptInsercao = @"INSERT INTO TBFUNCIONARIO
           ([NOME]
           ,[IDADE]
           ,[TELEFONE]
           ,[CPF]
           ,[RG]
           ,[UNHA]
           ,[CABELO]
           ,[DEPILACAO])
     VALUES
           ({0}NOME,
           {0}IDADE,
           {0}TELEFONE,
           {0}CPF,
           {0}RG,
           {0}UNHA,
           {0}CABELO,
           {0}DEPILACAO)";

        private const string _scriptRemocao = @"DELETE FROM TBFUNCIONARIO WHERE ID = {0}ID";

        private const string _scriptUpdate = @"UPDATE TBFUNCIONARIO SET NOME = {0}NOME
        ,[IDADE] = {0}IDADE
        ,[TELEFONE] = {0}TELEFONE
        ,[CPF] = {0}CPF
        ,[RG] = {0}RG
        ,[UNHA] = {0}UNHA
        ,[CABELO] = {0}CABELO
        ,[DEPILACAO] = {0}DEPILACAO
        WHERE ID = {0}ID";


        private const string _scriptBuscaPorId =
            @"SELECT [Id]
                  ,[NOME]
                  ,[IDADE]
                  ,[TELEFONE]
                  ,[CPF]
                  ,[RG]
                  ,[UNHA]
                  ,[CABELO]
                  ,[DEPILACAO]
              FROM [dbo].[TBFuncionario]
              WHERE [Id] = {0}Id";

        private const string _scriptExibir = @"SELECT [ID]
        ,[NOME]
        ,[IDADE]
        ,[TELEFONE]
        ,[CPF]
        ,[RG]
        ,[UNHA]
        ,[CABELO]
        ,[DEPILACAO]
        FROM [TBFUNCIONARIO]";

        public int Adicionar(Dominio.Funcionario novoFuncionario)
        {
            return Db.Insert(_scriptInsercao, BuscarParametros(novoFuncionario));
        }

        public IList<Dominio.Funcionario> BuscarTodos()
        {
            return Db.GetAll(_scriptExibir, ConverterFuncionario);
        }

        public void Editar(Dominio.Funcionario funcionario)
        {
            Db.Update(_scriptUpdate, BuscarParametros(funcionario));
        }


        public Dominio.Funcionario BuscarPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "Id", id } };

            return Db.Get(_scriptBuscaPorId, ConverterFuncionario, parms);
        }

        public void Deletar(int id)
        {
            var parms = new Dictionary<string, object> { { "Id", id } };

            Db.Delete(_scriptRemocao, parms);
        }

        # region Metódos Privados - Conversor e Manipulador de Parametros

        private Dominio.Funcionario ConverterFuncionario(IDataReader reader)
        {
            Dominio.Funcionario funcionario = new Dominio.Funcionario();
            funcionario.Id = Convert.ToInt32(reader["ID"]);
            funcionario.Nome = Convert.ToString(reader["NOME"]);
            funcionario.Idade = Convert.ToInt32(reader["IDADE"]);
            funcionario.Telefone = Convert.ToDouble(reader["TELEFONE"]);
            funcionario.CPF = Convert.ToDouble(reader["CPF"]);
            funcionario.RG = Convert.ToDouble(reader["RG"]);
            funcionario.Unha = Convert.ToBoolean(reader["UNHA"]);
            funcionario.Cabelo = Convert.ToBoolean(reader["CABELO"]);
            funcionario.Depilacao = Convert.ToBoolean(reader["DEPILACAO"]);

            return funcionario;
        }

        private Dictionary<string, object> BuscarParametros(Dominio.Funcionario funcionario)
        {
            return new Dictionary<string, object>
            {
                {"Id",funcionario.Id},
                { "NOME",funcionario.Nome},
                {"IDADE",funcionario.Idade},
                {"TELEFONE",funcionario.Telefone},
                {"CPF",funcionario.CPF},
                {"RG",funcionario.RG},
                {"UNHA",funcionario.Unha},
                { "CABELO",funcionario.Cabelo},
                {"DEPILACAO",funcionario.Depilacao},
            };
        }

        #endregion


        public List<Dominio.Funcionario> ObterFuncionarioParaCombobox(SqlConnection connection)
        {
            List<Dominio.Funcionario> _lista_funcionario = new List<Dominio.Funcionario>();
            SqlCommand command = new SqlCommand("SELECT * FROM TBFUNCIONARIO", connection);
            connection.Open();
            using (SqlDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    Dominio.Funcionario funcionario = new Dominio.Funcionario();
                    funcionario.Nome = ((read["NOME"].ToString()));
                    funcionario.Idade = Convert.ToInt32((read["IDADE"].ToString()));
                    funcionario.RG = Convert.ToDouble((read["RG"].ToString()));
                    funcionario.CPF = Convert.ToDouble((read["CPF"].ToString()));
                    funcionario.Telefone = Convert.ToDouble((read["TELEFONE"].ToString()));
                    funcionario.Unha = Convert.ToBoolean(read["UNHA"]);
                    funcionario.Cabelo = Convert.ToBoolean(read["CABELO"]);
                    funcionario.Depilacao = Convert.ToBoolean(read["DEPILACAO"]);

                    _lista_funcionario.Add(funcionario);
                }
            }
            connection.Close();

            return _lista_funcionario;
        }
    }
}
