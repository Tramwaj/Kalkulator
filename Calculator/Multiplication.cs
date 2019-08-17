using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Multiplication : TwoComponentOperation
    {
        
        public Multiplication(double x)
        {
            this.x = x;
            Symbol = "*";
        }

        public override double Wynik(double y)
        {
            this.y = y;
            return x * y;
        }
        
    }
}
