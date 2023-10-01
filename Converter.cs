using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Converter
    {
        private double usdRate;
        private double eurRate;
        private double plnRate;

        public Converter(double usd, double eur, double pln)
        {
            usdRate = usd;
            eurRate = eur;
            plnRate = pln;
        }
    }
}
