using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom
{
    class BinomialComplex
    {
        public double real { get; set; }
        public double imaginario { get; set; }

        public BinomialComplex(double real, double imaginario)
        {
            this.real = real;
            this.imaginario = imaginario;
        }

        public Boolean esPositivo(double numero)
        {
            return numero > 0;
        }

        public Boolean esNegativo(double num)
        {
            return num < 0;
        }

        public Boolean esCero(double num)
        {
            return num.Equals(0);
        }

        public string mostrar()
        {
            return "(" + real.ToString() + ";" + imaginario.ToString() + ")";
        }

        public Boolean algunoEsCero()
        {
            return this.esCero(real) || this.esCero(imaginario);
        }

        public int ubicacionCuadrante()
        {
            if (this.esPositivo(real) && this.esPositivo(imaginario))
            {
                return 1;
            }

            else if (this.esPositivo(real) && this.esNegativo(imaginario))
            {
                return 4;
            }

            else if (this.esNegativo(real) && this.esPositivo(imaginario))
            {
                return 2;
            }

            else return 3;
        }

        public double modulo()
        {
            return Functions.redondear(Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginario, 2)));
        }

        public double argumento()
        {
            double res = Math.Atan(imaginario / real);

            if (algunoEsCero())
            {
                if (esCero(imaginario) && esPositivo(real))
                {
                    return 0;
                }

                else if (esCero(real) && esPositivo(imaginario))
                {
                    return Functions.redondear(Math.PI / 2);
                }

                else if (esCero(real) && esNegativo(imaginario))
                {
                    return Functions.redondear((3 * Math.PI) / 2);
                }

                else if (esCero(real) && esCero(imaginario))
                {
                    return 0;
                }

                else return Functions.redondear(Math.PI);
            }

            else
            {
                if (!Functions.estaEnPrimerGiro(res))
                {
                    return Functions.redondear(Functions.llevarAPrimerGiro(res));
                }

                if (ubicacionCuadrante() != 3 && ubicacionCuadrante() != 2)
                {
                    return Functions.redondear(res);
                }

                else return Functions.redondear(res + Math.PI);
            }
        }

        public BinomialComplex conjugado()
        {
            return new BinomialComplex(real, -imaginario);
        }

        public PolarComplex convertirEnPolar()
        {
            return new PolarComplex(this.modulo(), this.argumento());
        }
    }
}
