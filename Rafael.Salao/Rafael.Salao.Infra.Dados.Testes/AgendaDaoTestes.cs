

using NUnit.Framework;
using Rafael.Salao.Infra.Dados.Agenda;

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


            //Criando funcionario inicial
            Dominio.Agenda novoRegistroAgenda = new Dominio.Agenda();
            novoRegistroAgenda.Funcionario.Id = 1;
            novoRegistroAgenda.Nome_cliente = "Daniela";
            novoRegistroAgenda.Servicos.Id = 1;
            novoRegistroAgenda.Horario = "20:00";
            novoRegistroAgenda.Data = "10/09/2019";

            //Adicionando o registro da agenda no banco
            _agendaDao.Adicionar(novoRegistroAgenda);
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
