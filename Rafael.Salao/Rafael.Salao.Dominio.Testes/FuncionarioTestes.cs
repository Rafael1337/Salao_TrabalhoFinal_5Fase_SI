using System;
using FluentAssertions;
using NUnit.Framework;
using Rafael.Salao.Dominio.Validations;


namespace Rafael.Salao.Dominio.Testes
{
    [TestFixture]
    public class FuncionarioTestes
    {
        [Test]
        public void Teste_Nome_Funcionario_Nao_Pode_Ser_Vazio()
        {
            var validation = new FuncionarioValidation();
            //ARRANGE
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = string.Empty;

            //ACTIONl
            Action resultado = () => validation.Validate(funcionario);
            
            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O nome não deve ser vazio!");
        }
    }
}
