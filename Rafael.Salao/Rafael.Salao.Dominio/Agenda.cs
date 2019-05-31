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
        private DateTime horario { get; set; }
        private string Nome_cliente { get; set; }
        private Funcionario Funcionario { get; set; }
        private Servicos servicos { get; set; }
    }
}
