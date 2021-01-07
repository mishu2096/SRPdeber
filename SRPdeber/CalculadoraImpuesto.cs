﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SRPdeber
{
    class CalculadoraImpuesto
    {
        public double CalcularImpuestoIessDelTrabajador(double sueldo)
        {
            return sueldo * 9.45 / 100;
        }
        public double CalcularImpuestoIessDelPatrono(double sueldo)
        {
            return sueldo * 12.25 / 100;
        }
    }
}
