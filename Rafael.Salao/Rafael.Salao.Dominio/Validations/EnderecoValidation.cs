using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            //Bairro Validations
            RuleFor(endereco => endereco.Bairro)
                .NotEmpty().WithMessage("Por favor informe um Bairro");

            //Rua Validations
            RuleFor(endereco => endereco.Rua)
                .NotEmpty().WithMessage("Por favor informe a Rua");

            //CEP
            RuleFor(endereco => endereco.CEP)
                .NotEmpty().WithMessage("Por favor informe o CEP");

            //COMPLEMENTO
            RuleFor(endereco => endereco.Complemento)
                .NotEmpty().WithMessage("Por favor informe um Complemento");

            //Numero
            RuleFor(endereco => endereco.Numero)
                .NotEmpty().WithMessage("Por favor informe um Numero da residencia");
        }
    }
}
