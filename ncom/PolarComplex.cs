using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom
{
    class PolarComplex
    {
        public double mod { get; set; }
        public double arg { get; set; }

        public PolarComplex(double mod, double arg)
        {
            this.mod = Math.Abs(mod);
            this.arg = arg;
        }

        public string mostrar()
        {
            return "[" + mod.ToString() + ";" + arg.ToString() + "]";
        }

        public string signoString()
        {
            if (arg > 0)
            {
                return "+";
            }

            else return "";
        }

        public BinomialComplex convertirEnBinomica()
        {
            return new BinomialComplex(Functions.redondear(mod * Math.Cos(arg)), Functions.redondear(mod * Math.Sin(arg)));
        }
    }
}
