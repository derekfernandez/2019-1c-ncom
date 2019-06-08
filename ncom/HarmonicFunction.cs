using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom
{
    class HarmonicFunction
    {
        public double amplitud { get; set; }
        public double frecuencia { get; set; }
        public double fase { get; set; }
        public Boolean esCoseno { get; set; }

        public HarmonicFunction(double amplitud, double frecuencia, double fase, Boolean fCos)
        {
            this.amplitud = amplitud;
            this.frecuencia = frecuencia;
            this.fase = fase;
            this.esCoseno = fCos;
        }

        /* 
        public void convertir()
        {
            // Convertir a f(sin)
            if (esCoseno)
            {
                fase = Math.Round(fase - (Math.PI / 2));
                esCoseno = false;
            }

            // Convertir a f(cos)
            else
            {
                fase = Math.Round(fase + (Math.PI / 2));
                esCoseno = true;
            }
        }
        */

        public HarmonicFunction convertirEnFcos()
        {
            if (!esCoseno)
            {
                fase = fase + ((double)Math.PI / 2);
                esCoseno = true;
            }

            return this;
        }

        public string stringTipo()
        {
            if (esCoseno)
            {
                return "cos";
            }

            else return "sin";
        }

        public string signoFase()
        {
            if (fase > 0)
            {
                return "+";
            }

            else return "";
        }

        public PolarComplex fasor()
        {
            return new PolarComplex(Math.Round(amplitud, 2), Math.Round(fase, 2));
        }

        public string mostrar()
        {
            if (esCoseno)
            {
                return Functions.quitarEspacios("" + amplitud.ToString() + "cos" + "(" + frecuencia.ToString()
                                 + "t " + signoFase() + " " + fase.ToString() + ")");

            }

            else
                return Functions.quitarEspacios("" + amplitud.ToString() + "sin" + "(" + frecuencia.ToString()
                                    + "t " + signoFase() + " " + fase.ToString() + ")");
        }
    }
}
