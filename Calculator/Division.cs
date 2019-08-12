using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Division : Operation
    {
        private double x=0;

        public Division(double x)
        {
            this.x = x;
            Symbol = "/";
        }
        public override double Wynik(double y)
        {
            return x / y;
        }
        
    }
}
