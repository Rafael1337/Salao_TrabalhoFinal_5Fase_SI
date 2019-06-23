using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Unha
    {
        public int Id { get; set; }
        public double Valor { get; set; }

        public Unha(double _valor)
        {
            Valor = _valor;
        }
    }
}
