using NUnit.Framework;
using Rafael.Salao.Dominio;
using Rafael.Salao.Infra.Dados.Funcionario;
using System.Configuration;
using Rafael.Salao.Infra.Dados;

namespace Rafael.Salao.Infra.Dados.Testes
{
    [TestFixture]
    public class FuncionarioDaoTestes
    {
        private FuncionarioDao _funcionarioDao;

        [SetUp]
        public void Inicializar()
        {
            _funcionarioDao = new FuncionarioDao();

            //Limpando do a tabela cliente
            //Db.Update("DELETE FROM [TBFUNCIONARIO]");
            //Zerando o Id
            //Db.Update("DBCC CHECKIDENT('[TBFUNCIONARIO]', RESEED, 0)");

            //Criando cliente inicial
            Dominio.Funcionario novoFuncionario = new Dominio.Funcionario();
            novoFuncionario.Nome = "Teste 1";
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

            //Adicionando o cliente no banco
            _funcionarioDao.Adicionar(novoFuncionario);
        }

        [Test]
        public void Teste_Deve_Adicionar_Um_Cliente_Que_Retorne_Um_Id_Valido()
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
