using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Caixa
    {
        private double Saldo { get; set; }

        public void AdicionarSaldo(double valor)
        {
            Saldo += valor;
        }

        public void RealizarFechamentoDoCaixa()
        {

        }
    }
}
