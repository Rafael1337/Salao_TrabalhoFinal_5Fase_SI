using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Rafael.Salao.Dominio.Validations
{
    public class FuncionarioValidation : AbstractValidator<Funcionario>
    {
        public FuncionarioValidation()
        {
            //Id Validations
            RuleFor(funcionario => funcionario.Id)
            .NotEmpty().WithMessage("O Id do funcionario registrado foi inserido vazio, por favor contate o suporte");

            //Nome Validations
            RuleFor(funcionario => funcionario.Nome)
            .Length(8, 900).WithMessage("O Nome do seu funcionario com toda certeza tem pelo menos 8 digitos né")
            .NotEmpty().WithMessage("Por favor informe o nome do funcionario");
           
            //Idade Validations
            RuleFor(funcionario => funcionario.Idade)
            .NotEmpty().WithMessage("Por favor informe a idade do funcionario")
            .LessThanOrEqualTo(0).WithMessage("A Idade do funcionario não pode ser zero");

            //CPF Validations
            RuleFor(funcionario => funcionario.CPF)
            .NotEmpty().WithMessage("Por favor informe o CPF do funcionario")
            .LessThan(11).WithMessage("O CPF deve conter pelo menos 11 digitos")
            .GreaterThan(11).WithMessage("Por favor informe um CPF valido contendo até 11 digitos");
            
            //RG Validations
            RuleFor(funcionario => funcionario.RG)
            .NotEmpty().WithMessage("Por favor informe o RG do funcionario")
            .LessThanOrEqualTo(6).WithMessage("Por favor informe um RG Valido")
            .GreaterThan(15).WithMessage("Por favor informe um RG Valido");

            //Telefone Validations
            RuleFor(funcionario => funcionario.Telefone)
            .NotEmpty().WithMessage("Por favor informe um telefone");

        }
    }
}
