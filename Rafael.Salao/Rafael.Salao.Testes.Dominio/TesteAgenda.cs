using NUnit.Framework;
using FluentValidation.TestHelper;
using Rafael.Salao.Dominio;
using System;
using FluentAssertions;

namespace Rafael.Salao.Testes.Dominio
{
    [TestFixture]
    public class TesteAgenda
    {
        public Agenda agenda;

        [SetUp]
        public void Inicializador()
        {
            agenda = new Agenda();

            //Criando registro agenda inicial
            agenda.Id = 1;
            agenda.Horario = "20:00";
            agenda.Nome_cliente = "Daniela";
            agenda.Telefone = "322202222";
            agenda.IdServico = 1;
            agenda.Idfuncionario = 1;
            agenda.Data = "10/09/2019";
        }

        [Test]
        public void Teste_Telefone_Agendado_Nao_Pode_Ser_Vazio()
        {

            agenda.Telefone = string.Empty;

            Action resultado = () => agenda.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O Telefone é um campo obrigatório para o Agendamento");
        }

        [Test]
        public void Teste_Nome_Cliente_Agendado_Nao_Pode_Ser_Vazio()
        {

            agenda.Nome_cliente = string.Empty;

            Action resultado = () => agenda.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O Nome do cliente é um campo obrigatório");
        }

        [Test]
        public void Teste_Horario_Agendado_Nao_Pode_Ser_Vazio()
        {
            agenda.Horario = string.Empty;

            Action resultado = () => agenda.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O Horário é um campo obrigatório para o Agendamento");
        }

        [Test]
        public void Teste_Servico_Agendado_Nao_Pode_Ser_Vazio()
        {
            agenda.IdServico = 0;
         
            Action resultado = () => agenda.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Serviço é um campo obrigatório para o Agendamento de horários");
        }

        [Test]
        public void Teste_Funcionario_Agendado_Nao_Pode_Ser_Vazio()
        {
           agenda.Idfuncionario = 0;
         
            Action resultado = () => agenda.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Funcionário é um campo obrigatório para o Agendamento de horáríos");
        }

        [Test]
        public void Teste_Data_Agendada_Nao_Pode_Ser_Vazia()
        {
            agenda.Data = string.Empty;
            Action resultado = () => agenda.Validacao();

            resultado.Should()
                .Throw<Exception>()
                .WithMessage("A Data é um campo obrigatório para o Agendamento");
        }
    }
}
