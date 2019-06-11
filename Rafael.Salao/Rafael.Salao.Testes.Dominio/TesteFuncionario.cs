using FluentAssertions;
using NUnit.Framework;
using Rafael.Salao.Dominio;
using Rafael.Salao.Dominio.Validations;
using System;
using FluentValidation;
using FluentValidation.TestHelper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Rafael.Salao.Testes.Dominio
{
    [TestFixture]
    public class TesteFuncionario
    {
        [Test]
        public void Teste_Id_Funcionario_Nao_Pode_Ser_Vazio()
        {
            var validation = new FuncionarioValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Id, (int)0);
        }

        [Test]
        public void Teste_Nome_Funcionario_Nao_Pode_Ser_Vazio()
        {
            var validation = new FuncionarioValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Nome, (string)null);
        }

        [Test]
        public void Teste_Idade_Funcionario_Nao_Pode_Ser_Vazio()
        {
            var validation = new FuncionarioValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Idade, (int)0);
        }

        [Test]
        public void Teste_Telefone_Funcionario_Nao_Pode_Ser_Vazio()
        {
            var validation = new FuncionarioValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Telefone, (double)0.0);
        }

        [Test]
        public void Teste_RG_Funcionario_Nao_Pode_Ser_Vazio()
        {
            var validation = new FuncionarioValidation();
            validation.ShouldHaveValidationErrorFor(x => x.RG, (double)0.0);
        }

        [Test]
        public void Teste_CPF_Funcionario_Nao_Pode_Ser_Vazio()
        {
            var validation = new FuncionarioValidation();
            validation.ShouldHaveValidationErrorFor(x => x.CPF, (double)0.0);
        }
    }
}
