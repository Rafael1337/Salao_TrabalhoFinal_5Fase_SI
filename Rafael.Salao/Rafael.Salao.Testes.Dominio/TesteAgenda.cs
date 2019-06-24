using NUnit.Framework;
using Rafael.Salao.Dominio.Validations;
using FluentValidation.TestHelper;

namespace Rafael.Salao.Testes.Dominio
{
    [TestFixture]
    public class TesteAgenda
    {
        [Test]
        public void Teste_Id_Agenda_Nao_Pode_Ser_Vazio()
        {
            var validation = new AgendaValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Id, (int)0);
        }

        [Test]
        public void Teste_Nome_Cliente_Agendado_Nao_Pode_Ser_Vazio()
        {
            var validation = new AgendaValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Nome_cliente, (string)null);
        }

        [Test]
        public void Teste_Horario_Agendado_Nao_Pode_Ser_Vazio()
        {
            var validation = new AgendaValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Horario, (string)null);
        }

        //[Test]
        //public void Teste_Servico_Agendado_Nao_Pode_Ser_Vazio()
        //{
        //    var validation = new AgendaValidation();
        //    validation.ShouldHaveValidationErrorFor(x => x.Servicos.Id, (int)0);
        //}

        [Test]
        public void Teste_Funcionario_Agendado_Nao_Pode_Ser_Vazio()
        {
            var validation = new AgendaValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Funcionario.Id, (int)0);
        }

        [Test]
        public void Teste_Data_Agendada_Nao_Pode_Ser_Vazia()
        {
            var validation = new AgendaValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Data, (string)null);
        }
    }
}
