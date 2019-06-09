using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Infra.Dados.Funcionario
{
    public class FuncionarioDao
    {
        string scriptInsercao = @"INSERT INTO TBFUNCIONARIO 
           ([NOME]
           ,[IDADE]
           ,[TELEFONE]
           ,[CPF]
           ,[RG])
           VALUES
           {0}NOME
           ,{0}IDADE
           ,{0}TELEFONE
           ,{0}CPF 
           ,{0}RG";

        string scriptRemocao = @"DELETE FROM TBFUNCIONARIO WHERE ID = {0}ID";
        string scriptUpdate = @"UPDATE SALAO_DATABASE TBFUNCIONARIO SET NOME = {0}NOME,
        ,[IDADE] = {0}IDADE
        ,[TELEFONE] = {0}TELEFONE
        ,[CPF] = {0}CPF
        ,[RG] = {0}RG
        WHERE ID = {0}ID";

        string scriptExibir = @"SELECT [ID]
        ,[NOME]
        ,[IDADE]
        ,[TELEFONE]
        ,[CPF]
        ,[RG]
        FROM [TBFUNCIONARIO]";


    }
}
