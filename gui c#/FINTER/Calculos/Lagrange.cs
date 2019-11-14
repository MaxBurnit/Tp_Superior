using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINTER.Calculos
{
    class Lagrange
    {
        public int calcularPolinomioLagrange(int[] x, int[] y, int xi)
        {
            int[] equis = (int[])x.Clone();
            int sm = 0;
            for (int i = 0; i < (equis.Length); i++)
            {
                int num = 1;
		int den = 1;
		int pr = 1;
                for (int j = 0; j < (equis.Length); j++)
                {
                    if (j != i)
                    {
                        num = num * (xi - x[j]);
			den = den * (x[i] - x[j]);
			pr = num / den;
                    }
                }
                sm = sm + (y[i] * pr);
            }

            return sm;
        }
        public String mostrarPolinomiosLagrange(int[] x)
        {
            int n = x.Length;
            string s = x.ToString();
            String polinomio = "";
            for (int i = 0; i < n; i++)
            {
                string numerador = " ";
                string denominador = " ";
               // string polinomio = " ";
                int den = 1;
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        numerador = numerador + "(x-(" + x[j].ToString() + "))";
                        den = den * (x[i] - x[j]);
                        denominador = den.ToString();
                    }
                }
                polinomio = polinomio + "L(" + i.ToString() + ")=" + numerador + "/" + denominador + "$";//$ el caracter para parsear el string
                Console.WriteLine(polinomio);
            }

            return polinomio;
        }

        public String polinomioAux(int[] x)
        {
            int n = x.Length;
            string s = x.ToString();
            String polinomio = "";
            for (int i = 0; i < n; i++)
            {
                string numerador = " ";
                string denominador = " ";
                // string polinomio = " ";
                int den = 1;
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        numerador = numerador + "(x-(" + x[j].ToString() + "))";
                        den = den * (x[i] - x[j]);
                        denominador = den.ToString();
                    }
                }
                polinomio = polinomio + numerador + "/" + denominador +")" + "$";//$ el caracter para parsear el string
                Console.WriteLine(polinomio);
            }

            return polinomio;


        }

        public String polinomioFinal(int[] xs, int[] ys)
        {
            String polinomioAux = this.polinomioAux(xs);
            String[] polinomios = polinomioAux.Split('$');
            String polinomioFinal = "";
            String signo = "";

            for(int i=0; i < ys.Length; i++)
            {
                if (i != ys.Length - 1)
                {
                    signo = "+";
                }
                polinomioFinal = polinomioFinal + polinomios[i] + "*" +ys[i].ToString() + signo;
                signo = "";

            }

            return polinomioFinal;

        }
    }
}
