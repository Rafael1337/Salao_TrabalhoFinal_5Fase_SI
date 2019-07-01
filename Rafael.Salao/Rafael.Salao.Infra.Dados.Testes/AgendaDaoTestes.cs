using System;
using System.Data.SqlClient;
using NUnit.Framework;
using Rafael.Salao.Dominio;
using Rafael.Salao.Infra.Dados.Agenda;
using Rafael.Salao.Infra.Dados.Funcionario;

namespace Rafael.Salao.Infra.Dados.Testes
{
    [TestFixture]
    public class AgendaDaoTestes
    {
        private DabaseConnection _databaseConnection = new DabaseConnection();
        private AgendaDao _agendaDao;

        [SetUp]
        public void Inicializar()
        {
            LimpaBanco();
            _agendaDao = new AgendaDao();
            //Adicionando funcionario
            AdicionaFuncionarioTesteAgenda();

            //Criando registro agenda inicial
            Dominio.Agenda novoRegistroAgenda = new Dominio.Agenda();
            novoRegistroAgenda.Horario = "20:00";
            novoRegistroAgenda.Nome_cliente = "Daniela";
            novoRegistroAgenda.IdServico = 1;
            novoRegistroAgenda.Idfuncionario = 1;
            novoRegistroAgenda.Data = "10/09/2019";

            //Adicionando o registro da agenda no banco
            _agendaDao.Adicionar(novoRegistroAgenda);
        }

        private void LimpaBanco()
        {
            Db.Update("DELETE FROM TBAGENDA");
            Db.Update("DBCC CHECKIDENT('[TBAGENDA]', RESEED, 0)");
            Db.Update("DELETE FROM TBFUNCIONARIO");
            Db.Update("DBCC CHECKIDENT('[TBFUNCIONARIO]', RESEED, 0)");
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
            novoRegistroAgenda.IdServico = 1;
            novoRegistroAgenda.Idfuncionario = 1;

            int idClienteAdicionado = 2;
            int quantidadeValida = 0;

            //AÇÃO

            var resultado = _agendaDao.Adicionar(novoRegistroAgenda);

            //VERIFICAÇÃO        
            Assert.True(resultado > quantidadeValida);
            Assert.AreEqual(idClienteAdicionado, resultado);
        }

        [Test]
        public void Teste_Deve_Deletar_Agenda_Por_Id()
        {
            int idAgenda = 1;
            int quantidadeAgenda = 0;

            _agendaDao.Deletar(idAgenda);

            var resultado = _agendaDao.BuscarTodos();
            Assert.AreEqual(quantidadeAgenda, resultado.Count);
        }


        [Test]
        public void Teste_Deve_Buscar_Todos_Os_Registros_Agenda()
        {
            int quantidadeAgenda = 1;

            var resultado = _agendaDao.BuscarTodos();

            Assert.AreEqual(quantidadeAgenda, resultado.Count);
        }
        
        [Test]
        public void Teste_Deve_Buscar_Id_Do_Funcionario_Para_Agenda()
        {
            string connectionString = "Server=localhost;Database=SALAO_DATABASE;User Id=sa;Password=p@ssw0rd";

            DabaseConnection.connection_created = new SqlConnection(connectionString);

            string nome_funcionario = "Teste 2";
            int esperado = 1;

            var resultado = _agendaDao.GetFuncionarioData(nome_funcionario);

            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void Teste_Deve_Buscar_Id_Do_Servico_Para_Agenda()
        {
            string connectionString = "Server=localhost;Database=SALAO_DATABASE;User Id=sa;Password=p@ssw0rd";

            DabaseConnection.connection_created = new SqlConnection(connectionString);

            string tipoServico = "PROGRESSIVA";
            int esperado = 1;

            var resultado = _agendaDao.GetServicoData(tipoServico);

            Assert.AreEqual(esperado, resultado);
        }
    }
}
