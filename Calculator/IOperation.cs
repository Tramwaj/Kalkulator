using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    
    public abstract class Operation
    {
        protected string Symbol = "";
        public abstract double Wynik(double y);
        public string DisplayOperation()
        {
            return Symbol;
        }
    }
}
