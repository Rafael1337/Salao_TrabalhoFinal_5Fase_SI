using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Depilacao
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }

        public Depilacao(string _tipo, double _valor)
        {
            Tipo = _tipo;
            Valor = _valor;
        }
    }
}
