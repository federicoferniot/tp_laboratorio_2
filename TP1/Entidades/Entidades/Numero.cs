﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;

        private double ValidarNumero(string strNumero)
        {
            double resultado=0;
            Double.TryParse(strNumero, out resultado);
            return resultado;
        }
    }
}