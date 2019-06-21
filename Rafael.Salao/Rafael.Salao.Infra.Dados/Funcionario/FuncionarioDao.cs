using Rafael.Salao.Dominio;
using System;
using System.Collections.Generic;
using System.Data;

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
           ,[BAIRRO]
           ,[RUA]
           ,[NUMERO]
           ,[CEP]
           ,[COMPLEMENTO])
     VALUES
           ({0}NOME,
           {0}IDADE,
           {0}TELEFONE,
           {0}CPF,
           {0}RG,
           {0}BAIRRO,
           {0}RUA,
           {0}NUMERO,
           {0}CEP,
           {0}COMPLEMENTO)";

        private const string _scriptRemocao = @"DELETE FROM TBFUNCIONARIO WHERE ID = {0}ID";

        private const string _scriptUpdate = @"UPDATE SALAO_DATABASE TBFUNCIONARIO SET NOME = {0}NOME,
        ,[IDADE] = {0}IDADE
        ,[TELEFONE] = {0}TELEFONE
        ,[CPF] = {0}CPF
        ,[RG] = {0}RG
        WHERE ID = {0}ID";


        private const string _scriptBuscaPorId =
            @"SELECT [Id]
                  ,[NOME]
                  ,[IDADE]
                  ,[TELEFONE]
                  ,[CPF]
                  ,[RG]
              FROM [dbo].[TBFuncionario]
              WHERE [Id] = {0}Id";

        private const string _scriptExibir = @"SELECT [ID]
        ,[NOME]
        ,[IDADE]
        ,[TELEFONE]
        ,[CPF]
        ,[RG]
        FROM [TBFUNCIONARIO]";

        public int Adicionar(Dominio.Funcionario novoFuncionario)
        {
            return Db.Insert(_scriptInsercao, BuscarParametros(novoFuncionario));
        }

        public IList<Dominio.Funcionario> BuscarTodos()
        {
            return Db.GetAll(_scriptExibir, ConverterFuncionario);
        }

        public Dominio.Funcionario BuscarPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "Id", id } };

            return Db.Get(_scriptBuscaPorId, ConverterFuncionario, parms);
        }

        public void Editar(Dominio.Funcionario funcionario)
        {
            Db.Update(_scriptUpdate, BuscarParametros(funcionario));
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
            funcionario.Endereco = new Endereco
            {
                Bairro = Convert.ToString(reader["BAIRRO"]),
                Rua = Convert.ToString(reader["RUA"]),
                Numero = Convert.ToString(reader["NUMERO"]),
                CEP = Convert.ToString(reader["CEP"]),
                Complemento = Convert.ToString(reader["COMPLEMENTO"]),
            };

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
                {"BAIRRO",funcionario.Endereco.Bairro},
                {"RUA",funcionario.Endereco.Rua},
                {"NUMERO",funcionario.Endereco.Numero},
                { "CEP",funcionario.Endereco.CEP},
                {"COMPLEMENTO",funcionario.Endereco.Complemento},

            };
        }

        #endregion
    }
}
