using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ncom
{
    class Functions
    {
        public Functions()
        {
        }

        public static Boolean esNumero(Char letra)
        {
            return Char.IsNumber(letra) || Char.IsPunctuation(letra);
        }

        public static Boolean textboxCompletos(Control window)
        {
            List<TextBox> entries = new List<TextBox>();

            foreach (Control obj in window.Controls)
                {
                    if (obj is TextBox)
                    {
                        entries.Add((TextBox)obj);
                    }
                }

            return entries.TrueForAll(entry => !String.IsNullOrWhiteSpace(entry.Text));
        }

        public static Boolean esNumeroNatural(String cad)
        {
            List<Char> li = new List<char>();

            foreach (Char c in cad)
            {
                li.Add(c);
            }

            return li.TrueForAll(d => Char.IsNumber(d));
        }
        
        public static Boolean formatoNumericoValido(String palabra)
        {
            Regex r = new Regex(@"^[\-]?[\d]+[\.]?([\d]+)?$");
            Match m = r.Match(palabra);
            return m.Success;
        }

        public static Boolean textbox_soloNum(TextBox entry)
        {
            List<Char> li = new List<char>();

            foreach (Char l in entry.Text)
            {
                li.Add(l);
            }

            return li.TrueForAll(l => esNumero(l)) && formatoNumericoValido(entry.Text);
        }

        public static double redondear(double num)
        {
            return Math.Round(num, 2);
        }

        internal static Boolean estaEnPrimerGiro(double arg)
        {
            return arg < 2 * Math.Round(Math.PI, 2);
        }

        internal static double llevarAPrimerGiro(double arg)
        {
            while (!estaEnPrimerGiro(arg))
            {
                arg = arg - 2 * Math.Round(Math.PI, 2);
            }

            return arg;
        }

        public static List<double> divisoresDe(double val)
        {
            List<double> divs = new List<double>();

            for (int i = 1; i <= val; i++)
            {
                int resto;
                Math.DivRem((int)val, i, out resto);

                if (resto.Equals(0))
                {
                    divs.Add(i);
                }
            }

            return divs;
        }

        internal static double mcd(double valor, double otroValor)
        {
            var divisoresA = divisoresDe(valor);
            var divisoresB = divisoresDe(otroValor);

            var divisoresComunes = divisoresA.Where(n => divisoresB.Contains(n)).ToList();

            var maxDiv = divisoresComunes.Max();

            return maxDiv;
        }

        internal static List<BinomialComplex> convertirTodosABinom(List<string> li)
        {
            List<BinomialComplex> numeros = new List<BinomialComplex>();

            foreach (String c in li)
            {
                if (Functions.esPolar(c))
                {
                    var polar = Functions.conversionStringPolar(c);
                    BinomialComplex binom = polar.convertirEnBinomica();
                    numeros.Add(binom);
                }

                else
                {
                    var binom = Functions.conversionStringBinomica(c);
                    numeros.Add(binom);
                }
            }

            return numeros;
        }

        public static Boolean esComplejoValido(String complex)
        {
            Regex regex = new Regex(@"^([\[][\-]?[\d]+([\.]?[\d]+)?(\s)?[\;](\s)?[\-]?[\d]+([\.]?[\d]+)?[\]])|([\(][\-]?[\d]+([\.]?[\d]+)?(\s)?[\;](\s)?[\-]?[\d]+([\.]?[\d]+)?[\)])$");
            Match m = regex.Match(complex);
            return m.Success;
        }

        public static string formatear(string complex)
        {
            while (complex.Contains(" "))
            {
                complex = complex.Replace(" ", "");
            }

            complex = complex.Remove(0, 1);
            complex = complex.Remove(complex.Length - 1, 1);

            return complex;
        }

        public static BinomialComplex conversionStringBinomica(string complex)
        {
            complex = formatear(complex);
            string[] partes = complex.Split(';');
            return new BinomialComplex(double.Parse(partes[0]), double.Parse(partes[1]));
        }

        public static PolarComplex conversionStringPolar(string complex)
        {
            complex = formatear(complex);
            string[] partes = complex.Split(';');
            return new PolarComplex(double.Parse(partes[0]), double.Parse(partes[1]));
        }

        public static Boolean esBinomico(string n)
        {
            return n.Contains("(") && n.Contains(")");
        }

        public static Boolean esPolar(string n)
        {
            return n.Contains("[") && n.Contains("]");
        }

        public static BinomialComplex producto(BinomialComplex n1, BinomialComplex n2)
        {
            return new BinomialComplex((n1.real * n2.real)
                    - (n1.imaginario * n2.imaginario)
                        , (n1.imaginario * n2.real)
                            + (n2.imaginario * n1.real));
        }

        public static BinomialComplex cociente(BinomialComplex dividendo, BinomialComplex divisor)
        {
            BinomialComplex conjugadoDivisor = new BinomialComplex(divisor.real, divisor.imaginario * -1);

            return new BinomialComplex(Functions.redondear(Functions.producto(dividendo, conjugadoDivisor).real / Functions.producto(divisor, conjugadoDivisor).real)
                   , Functions.redondear(Functions.producto(dividendo, conjugadoDivisor).imaginario / Functions.producto(divisor, conjugadoDivisor).real));
        }

        public static BinomialComplex suma(BinomialComplex n1, BinomialComplex n2)
        {
            return new BinomialComplex(n1.real + n2.real, n1.imaginario + n2.imaginario);
        }

        public static BinomialComplex resta(BinomialComplex n1, BinomialComplex n2)
        {
            return new BinomialComplex(n1.real - n2.real, n1.imaginario - n2.imaginario);
        }

        public static PolarComplex potenciacion(PolarComplex num, int potencia)
        {        
            var newMod = Math.Pow(num.mod, potencia);
            var newArg = llevarAPrimerGiro(num.arg * potencia);

            return new PolarComplex(Math.Round(newMod, 2), Math.Round(newArg, 2));
        }

        public static List<PolarComplex> radicacion(PolarComplex num, double raiz)
        {
            List<PolarComplex> li = new List<PolarComplex>();

            for (int i = 0; i < raiz; i++)
            {
                double newMod = Math.Round(Math.Pow(num.mod, 1 / raiz), 2);
                double newArg = Math.Round((num.arg + (2 * Math.Round(Math.PI, 2) * i)) / raiz, 2);
                li.Add(new PolarComplex(newMod, newArg));
            }

            return li;
        }

        public static List<PolarComplex> raicesUnidad(int cuantas)
        {
            List<PolarComplex> li = new List<PolarComplex>();

            for (int i = 0; i < cuantas; i++)
            {
                li.Add(new PolarComplex(1, Math.Round(Math.Round(2 * Math.PI, 2) * i / cuantas, 2)));
            }

            return li;
        }

        public static List<double> raicesPrimitivas(int totalRaices)
        {
            List<double> li = new List<double>();

            for (int raizActual = 1; raizActual < totalRaices; raizActual++)
            {
                var val = mcd(raizActual, totalRaices);

                if (val.Equals(1))
                {
                    li.Add(raizActual);
                }
            }

            return li;
        }

        public static HarmonicFunction sumaDeFuncArmonicas(HarmonicFunction f1, HarmonicFunction f2)
        {
            var fasorA = f1.fasor();
            var fasorB = f2.fasor();

            var res = Functions.suma(fasorA.convertirEnBinomica(), fasorB.convertirEnBinomica());
            var resPolar = res.convertirEnPolar();

            return new HarmonicFunction(resPolar.mod, f1.frecuencia, resPolar.arg, true);
        }

        public static HarmonicFunction restaDeFuncArmonicas(HarmonicFunction f1, HarmonicFunction f2)
        {
            var fasorA = f1.fasor();
            var fasorB = f2.fasor();

            var res = Functions.resta(fasorA.convertirEnBinomica(), fasorB.convertirEnBinomica());
            var resPolar = res.convertirEnPolar();

            return new HarmonicFunction(resPolar.mod, f1.frecuencia, resPolar.arg, true);
        }

        public static Boolean esPlaceholder(TextBox e)
        {
            return e.Text.Contains("Ejemplo");
        }

        public static Boolean entryNoVacio(TextBox e)
        {
            return !string.IsNullOrWhiteSpace(e.Text);
        }

        public static string quitarEspacios(string s)
        {
            s = s.Replace(" ", "");
            return s;
        }
    }
}
