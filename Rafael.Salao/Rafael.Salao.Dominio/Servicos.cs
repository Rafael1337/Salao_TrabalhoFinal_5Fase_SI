using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Servicos
    {
        public int Id { get; set; }
        public Cabelo Cabelo { get; set; }
        public Unha Unha { get; set; }
        public Depilacao Depilacao { get; set; }
    }
}
