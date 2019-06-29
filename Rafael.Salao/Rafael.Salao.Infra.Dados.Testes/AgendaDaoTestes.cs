

using System;
using NUnit.Framework;
using Rafael.Salao.Dominio;
using Rafael.Salao.Infra.Dados.Agenda;
using Rafael.Salao.Infra.Dados.Funcionario;

namespace Rafael.Salao.Infra.Dados.Testes
{
    [TestFixture]
    public class AgendaDaoTestes
    {
        private AgendaDao _agendaDao;

        [SetUp]
        public void Inicializar()
        {
            _agendaDao = new AgendaDao();
            //Adicionando funcionario
            AdicionaFuncionarioTesteAgenda();

            //Criando registro agenda inicial
            Dominio.Agenda novoRegistroAgenda = new Dominio.Agenda();
            novoRegistroAgenda.Horario = "20:00";
            novoRegistroAgenda.Nome_cliente = "Daniela";
            novoRegistroAgenda.Servicos.Id = 1;
            novoRegistroAgenda.Funcionario.Id = 1;
            novoRegistroAgenda.Data = "10/09/2019";

            //Adicionando o registro da agenda no banco
            _agendaDao.Adicionar(novoRegistroAgenda);
        }

        private void AdicionarValoresDeServico()
        {

        }

        private void AdicionaFuncionarioTesteAgenda()
        {

           FuncionarioDao _funcionarioDao = new FuncionarioDao();

            Dominio.Funcionario novoFuncionario = new Dominio.Funcionario();
            novoFuncionario.Nome = "Teste 2";
            novoFuncionario.Idade = 13;
            novoFuncionario.Telefone = 1333;
            novoFuncionario.CPF = 09016801928;
            novoFuncionario.RG = 5972961;

            _funcionarioDao.Adicionar(novoFuncionario);
        }

        [Test]
        public void Teste_Deve_Adicionar_Um_RegistroNaAgenda()
        {
            //CENÁRIO

            Dominio.Agenda novoRegistroAgenda = new Dominio.Agenda();
            novoRegistroAgenda.Nome_cliente = "Cliente1";
            novoRegistroAgenda.Horario = "13:00:00";
            novoRegistroAgenda.Data = "10/10/2019";
            novoRegistroAgenda.Servicos.Id = 1;
            novoRegistroAgenda.Funcionario.Id = 1;

            int idClienteAdicionado = 2;
            int quantidadeValida = 0;

            //AÇÃO

            var resultado = _agendaDao.Adicionar(novoRegistroAgenda);

            //VERIFICAÇÃO        
            Assert.True(resultado > quantidadeValida);
            Assert.AreEqual(idClienteAdicionado, resultado);
        }
    }
}
