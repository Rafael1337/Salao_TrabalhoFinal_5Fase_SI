﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Depilacao
    {
        public int Id { get; set; }
        public double Valor { get; set; }

        public Depilacao(double _valor)
        {
            Valor = _valor;
        }
    }
}
