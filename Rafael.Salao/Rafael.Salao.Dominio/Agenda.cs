using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Agenda
    {
        public int Id {get; set;}
        public string Horario { get; set; }
        public string Nome_cliente { get; set; }
        public string Telefone { get; set; }
        public int Idfuncionario { get; set; }
        public int IdServico { get; set; }
        public string Data { get; set; }

        private IValidatorFactory validatorFactory;
        private List<IValidator> _validators;

        public void Validate(Agenda entity)
        {
            var validator = validatorFactory.GetValidator(entity.GetType());

            if (validator == null)
                return;

            var validation = validator.Validate(entity);

            if (validation.Errors.Count > 0)
                throw new Exception(validation.Errors[0].ErrorMessage);
        }

        public IValidator GetValidator(Type type)
        {
            return _validators.FirstOrDefault(x => x.CanValidateInstancesOfType(type));
        }
    }
}
