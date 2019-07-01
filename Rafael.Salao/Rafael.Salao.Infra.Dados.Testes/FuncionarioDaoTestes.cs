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
            novoFuncionario.Telefone = "323";
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
            Db.Update("DELETE FROM TBAGENDA");
            Db.Update("DBCC CHECKIDENT('[TBAGENDA]', RESEED, 0)");
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
            novoFuncionario.Telefone = "323";
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

        [Test]
        public void Teste_Deve_Deletar_Funcionario_Por_Id()
        {
            int idFuncionarioDeletado = 1;
            int quantidadeFuncionario = 0;

            _funcionarioDao.Deletar(idFuncionarioDeletado);

            var resultado = _funcionarioDao.BuscarTodos();
            Assert.AreEqual(quantidadeFuncionario, resultado.Count);
        }

        [Test]
        public void Teste_Deve_Buscar_Todos_Os_Funcionarios()
        {
            int quantidadeFuncionarios = 1;

            var resultado = _funcionarioDao.BuscarTodos();

            Assert.AreEqual(quantidadeFuncionarios, resultado.Count);
        }


        [Test]
        public void Teste_Deve_Editar_Qualquer_Campo_do_Funcionario()
        {
            //CENÁRIO
            int idFuncionarioEditado = 1;
            string telefoneEditado = "9990";
            Dominio.Funcionario funcionarioEditado = _funcionarioDao.BuscarPorId(idFuncionarioEditado);

            //AÇÃO
            funcionarioEditado.Telefone = telefoneEditado;
            _funcionarioDao.Editar(funcionarioEditado);

            Dominio.Funcionario funcionarioBuscado = _funcionarioDao.BuscarPorId(idFuncionarioEditado);
            Assert.AreEqual(telefoneEditado, funcionarioBuscado.Telefone);
        }


        [Test]
        public void Teste_Deve_Buscar_Funcionario_Por_Id()
        {
            int idFuncionarioBuscar = 1;

            Dominio.Funcionario resultado = _funcionarioDao.BuscarPorId(idFuncionarioBuscar);

            Assert.NotNull(resultado);
        }
    }
}
