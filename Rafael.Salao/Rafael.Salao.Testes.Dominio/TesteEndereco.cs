using FluentValidation.TestHelper;
using NUnit.Framework;
using Rafael.Salao.Dominio.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Testes.Dominio
{
    [TestFixture]
    public class TesteEndereco
    {
        [Test]
        public void Teste_Rua_Endereco_Nao_Pode_Ser_Vazio()
        {
            var validation = new EnderecoValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Rua, (string)null);
        }

        [Test]
        public void Teste_Bairro_Endereco_Nao_Pode_Ser_Vazio()
        {
            var validation = new EnderecoValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Bairro, (string)null);
        }

        [Test]
        public void Teste_CEP_Endereco_Nao_Pode_Ser_Vazio()
        {
            var validation = new EnderecoValidation();
            validation.ShouldHaveValidationErrorFor(x => x.CEP, (string)null);
        }

        [Test]
        public void Teste_Complemento_Endereco_Nao_Pode_Ser_Vazio()
        {
            var validation = new EnderecoValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Complemento, (string)null);
        }


        [Test]
        public void Teste_Numero_Endereco_Nao_Pode_Ser_Vazio()
        {
            var validation = new EnderecoValidation();
            validation.ShouldHaveValidationErrorFor(x => x.Numero, (string)null);
        }
    }
}
