using FluentValidation;

namespace Rafael.Salao.Dominio.Validations
{
    public class AgendaValidation : AbstractValidator<Agenda>
    {
        public AgendaValidation()
        {
            //id Validations
            RuleFor(agenda => agenda.Id)
            .NotEmpty().WithMessage("O Id do Agendamento registrado foi inserido vazio, por favor contate o suporte");

            //Nome_Cliente
            RuleFor(agenda => agenda.Nome_cliente)
                .NotEmpty().WithMessage("O Nome do cliente é um campo obrigatório");

            //Horario
            RuleFor(agenda => agenda.Horario)
                .NotEmpty().WithMessage("O Horário é um campo obrigatório para o Agendamento")
                .Matches("/^(0?[1-9]|1[0-2]):[0-5][0-9]\\d$/").WithMessage("Informe uma hora valida!");

            //Data
            RuleFor(agenda => agenda.Data)
                .NotEmpty().WithMessage("A Data é um campo obrigatório para o Agendamento")
                .Matches("^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\\d\\d$").WithMessage("Informe uma data valida para ser registrada!");

            //Servicos 
            RuleFor(agenda => agenda.Servicos)
                .NotNull().WithMessage("Serviço é um campo obrigatório para o Agendamento de horários");

            //Funcionario
            RuleFor(agenda => agenda.Funcionario)
                .NotNull().WithMessage("Funcionário é um campo obrigatório para o Agendamento de horáríos");
        }
    }
}
