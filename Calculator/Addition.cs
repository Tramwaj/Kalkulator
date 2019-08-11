using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Addition : IOperation
    {

        private double x = 0;
        public Addition(double x) => this.x = x;
        public double Wynik(double y)
        {
            return x + y;
        }
        public string DisplayOperation()
        {
            return "+";
        }
    }
}
