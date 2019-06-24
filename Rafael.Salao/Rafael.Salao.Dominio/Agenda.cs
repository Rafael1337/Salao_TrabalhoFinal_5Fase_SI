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
        public Funcionario Funcionario { get; set; }
        public Servicos Servicos { get; set; }
        public string Data { get; set; }
    }
}
