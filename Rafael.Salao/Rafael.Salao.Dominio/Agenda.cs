using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Agenda
    {
        private int Id {get; set;}
        private DateTime Horario { get; set; }
        private string Nome_cliente { get; set; }
        private Funcionario Funcionario { get; set; }
        private Servicos Servicos { get; set; }

        public Agenda(DateTime _horario, string _nome_cliente, Funcionario _funcionario, Servicos _servicos)
        {
            Horario = _horario;
            Nome_cliente = _nome_cliente;
            Funcionario = _funcionario;
            Servicos = _servicos;
        }
    }
}
