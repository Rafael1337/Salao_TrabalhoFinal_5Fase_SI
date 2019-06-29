using NUnit.Framework;
using Rafael.Salao.Dominio;
using Rafael.Salao.Infra.Dados.Funcionario;
using System.Configuration;
using Rafael.Salao.Infra.Dados;
using System;

namespace Rafael.Salao.Infra.Dados.Testes
{
    [TestFixture]
    public class FuncionarioDaoTestes
    {
        private FuncionarioDao _funcionarioDao;

        [SetUp]
        public void Inicializar()
        {

            LimpaBanco();
            _funcionarioDao = new FuncionarioDao();


            //Criando funcionario inicial
            Dominio.Funcionario novoFuncionario = new Dominio.Funcionario();
            novoFuncionario.Nome = "Teste 1";
            novoFuncionario.Idade = 13;
            novoFuncionario.Telefone = 1333;
            novoFuncionario.CPF = 09016801928;
            novoFuncionario.RG = 5972961;
            novoFuncionario.Unha = true;
            novoFuncionario.Cabelo = false;
            novoFuncionario.Depilacao = false;

            //Adicionando o funcionario no banco
            _funcionarioDao.Adicionar(novoFuncionario);
        }

        private void LimpaBanco()
        {
            Db.Update("DELETE FROM TBFUNCIONARIO");
            Db.Update("DBCC CHECKIDENT('[TBFUNCIONARIO]', RESEED, 0)");
        }

        [Test]
        public void Teste_Deve_Adicionar_Um_Funcionario()
        {
            //CENÁRIO

            Dominio.Funcionario novoFuncionario = new Dominio.Funcionario();
            novoFuncionario.Nome = "Teste 2";
            novoFuncionario.Idade = 13;
            novoFuncionario.Telefone = 1333;
            novoFuncionario.CPF = 09016801928;
            novoFuncionario.RG = 5972961;
            novoFuncionario.Unha = false;
            novoFuncionario.Cabelo = false;
            novoFuncionario.Depilacao = true;


            int idFuncionarioAdicionado = 2;
            int quantidadeValida = 0;

            //AÇÃO
            var resultado = _funcionarioDao.Adicionar(novoFuncionario);

            //VERIFICAÇÃO        
            Assert.True(resultado > quantidadeValida);
            Assert.AreEqual(idFuncionarioAdicionado, resultado);
        }

    }
}
