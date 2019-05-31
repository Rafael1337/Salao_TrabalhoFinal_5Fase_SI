using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Funcionario
    {
        private int Id { get;  set; }
        private string Nome { get; set; }
        private int Idade { get; set; }
        private double Telefone { get; set; }
        private double RG { get; set; }
        private double CPF { get; set; }

        public Funcionario(string _nome, int _idade, double _telefone, double _rg, double _cpf)
        {
            Id = FuncionarioGetId();
            Nome = _nome;
            Idade = _idade;
            Telefone = _telefone;
            RG = _rg;
            CPF = _cpf;
        }

        private int FuncionarioGetId()
        {
            return 0+1;
        }
    }
}
