using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.Calculator
{
    class Addition : Operation
    {
      
        private double x;

        public double Wynik(double y)
        {
            return x + y;
        }
    }
}
