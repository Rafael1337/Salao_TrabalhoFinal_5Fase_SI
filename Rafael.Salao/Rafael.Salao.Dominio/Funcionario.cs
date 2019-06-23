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
        public double Telefone { get; set; }
        public double RG { get; set; }
        public double CPF { get; set; }
        public Endereco Endereco { get; set; }
        public bool Unha { get; set; }
        public bool Cabelo { get; set; }
        public bool Depilacao { get; set; }
    }
}
