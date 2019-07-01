using NUnit.Framework;
using FluentValidation.TestHelper;
using Rafael.Salao.Dominio;
using System;
using FluentAssertions;

namespace Rafael.Salao.Testes.Dominio
{
    [TestFixture]
    public class TesteFuncionario
    {
        public Funcionario funcionario;
        [SetUp]
        public void Inicializador()
        {
            funcionario = new Funcionario();

            //Criando registro agenda inicial
            funcionario.Id = 1;
            funcionario.Nome = "Menina da tia Carmen";
            funcionario.Idade = 66;
            funcionario.RG = 322202222;
            funcionario.Telefone = "11111";
            funcionario.CPF = 11111111111;
            funcionario.Depilacao = true;
            funcionario.Unha = true;
            funcionario.Cabelo = false;
        }

        [Test]
        public void Teste_Nome_Funcionario_Nao_Pode_Ser_Vazio()
        {
            funcionario.Nome = string.Empty;

            Action resultado = () => funcionario.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Por favor informe o nome do funcionario");
        }


        [Test]
        public void Teste_Telefone_Funcionario_Nao_Pode_Ser_Vazio()
        {
            funcionario.Telefone = string.Empty;

            Action resultado = () => funcionario.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Por favor informe um telefone");
        }

        [Test]
        public void Teste_CPF_Funcionario_Nao_Pode_Ser_Vazio()
        {
            funcionario.CPF = 0;

            Action resultado = () => funcionario.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Por favor informe o CPF do funcionario");
        }

        [Test]
        public void Teste_CPF_Funcionario_Nao_Pode_Ter_Menos_de_11_Digitos()
        {
            funcionario.CPF = 1111;

            Action resultado = () => funcionario.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O CPF deve conter pelo menos 11 digitos");
        }

        [Test]
        public void Teste_CPF_Funcionario_Nao_Pode_Ter_Mais_de_11_Digitos()
        {
            funcionario.CPF = 111111111111;

            Action resultado = () => funcionario.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O CPF Pode ter somente 11 digitos");
        }

        [Test]
        public void Teste_RG_Funcionario_Nao_Pode_Ser_Vazio()
        {
            funcionario.RG = 0;

            Action resultado = () => funcionario.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Por favor informe o RG do funcionario");
        }

        [Test]
        public void Teste_RG_Funcionario_Nao_Pode_Ter_Mais_de_15_Digitos()
        {
            funcionario.RG = 1111111111111111;

            Action resultado = () => funcionario.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Por favor informe um RG Valido com no maximo 15 digitos");
        }

        [Test]
        public void Teste_RG_Funcionario_Nao_Pode_Ter_Menos_de_6_Digitos()
        {
            funcionario.RG = 12345;

            Action resultado = () => funcionario.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Por favor informe um RG Valido com ate 6 digitos");
        }
    }
}
