using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Funcionario
    {
        public int Id { get;  set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public double RG { get; set; }
        public double CPF { get; set; }
        public bool Unha { get; set; }
        public bool Cabelo { get; set; }
        public bool Depilacao { get; set; }

        public void Validacao()
        {
            //Nome Validations
            if(string.IsNullOrEmpty(Nome) || string.IsNullOrWhiteSpace(Nome))
                throw new Exception("Por favor informe o nome do funcionario");

            if (Nome.Length < 8)
                throw new Exception("O Nome do seu funcionario com toda certeza tem pelo menos 8 digitos né");

            //Idade Validations
            if (Idade == 0)
                throw new Exception("A Idade do funcionario não pode ser zero");

            //CPF Validations
            if (CPF == 0.0)
                throw new Exception("Por favor informe o CPF do funcionario");

            if (CPF.ToString().Length < 11)
                throw new Exception("O CPF deve conter pelo menos 11 digitos");

            if (CPF.ToString().Length > 11)
                throw new Exception("O CPF Pode ter somente 11 digitos");


            //RG Validations
            if (RG == 0.0)
                throw new Exception("Por favor informe o RG do funcionario");

            if (RG.ToString().Length < 6)
                throw new Exception("Por favor informe um RG Valido com ate 6 digitos");

            if(RG.ToString().Length > 15)
                    throw new Exception("Por favor informe um RG Valido com no maximo 15 digitos");

            //Telefone Validations
            if(string.IsNullOrEmpty(Telefone) || string.IsNullOrWhiteSpace(Telefone))
             throw new Exception("Por favor informe um telefone");
        }
    }
}
