

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
            novoRegistroAgenda.Servicos.Depilacao.Valor = 50;
            novoRegistroAgenda.Servicos.Cabelo.Valor = 50;
            novoRegistroAgenda.Servicos.Unha.Valor = 50;
            novoRegistroAgenda.Horario = "20:00";
            novoRegistroAgenda.Data = "10/09/2019";

            //Adicionando o funcionario no banco
            _agendaDao.Adicionar(novoRegistroAgenda);
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
            novoFuncionario.Endereco = new Endereco();
            {
                novoFuncionario.Endereco.Rua = "RUA";
                novoFuncionario.Endereco.Bairro = "BAIRRO";
                novoFuncionario.Endereco.Numero = "402";
                novoFuncionario.Endereco.Complemento = "COMPLEMENTO";
                novoFuncionario.Endereco.CEP = "88505300";
            };

            int idClienteAdicionado = 2;
            int quantidadeValida = 0;

            //AÇÃO

            var resultado = _funcionarioDao.Adicionar(novoFuncionario);

            //VERIFICAÇÃO        
            Assert.True(resultado > quantidadeValida);
            Assert.AreEqual(idClienteAdicionado, resultado);
        }
    }
}
