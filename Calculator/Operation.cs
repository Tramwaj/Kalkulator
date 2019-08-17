using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    
    public abstract class TwoComponentOperation
    {
        protected double x;
        protected double y;
        protected string Symbol = "";
        public abstract double Wynik(double y);
        public string DisplayOperation()
        {
            return Symbol;
        }
        public string TextForHistory()
        {
            return (x.ToString() + Symbol + y.ToString());
        }
    }
}
