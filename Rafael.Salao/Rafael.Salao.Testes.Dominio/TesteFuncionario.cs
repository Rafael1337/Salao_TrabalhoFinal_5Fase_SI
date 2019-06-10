using FluentAssertions;
using NUnit.Framework;
using Rafael.Salao.Dominio;
using Rafael.Salao.Dominio.Validations;
using System;
using FluentValidation;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Testes.Dominio
{
    [TestFixture]
    public class TesteFuncionario
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
                .WithMessage("Por favor informe o nome do funcionario");
        }
    }
}
