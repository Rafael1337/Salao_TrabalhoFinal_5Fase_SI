using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Unha
    {
        private int Id { get; set; }
        private string Tipo { get; set; }
        private double Valor { get; set; }

        public Unha(string _tipo, double _valor)
        {
            Tipo = _tipo;
            Valor = _valor;
        }
    }
}
