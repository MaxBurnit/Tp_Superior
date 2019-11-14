using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINTER.Calculos
{
    class NewtonGregoryReg
    {
        public int[,] tablaDeDiferenciasRegresivo(int[] xs, int tamanioVector, int[,] matriz)
        {
            //int[,] matrizResultado = new int[tamanioVector, tamanioVector];
            int [,] matrizResultado = matriz; 
            for (int j = 1; j < tamanioVector; j++)
            {
                for (int i = tamanioVector - 1; i >= j; i--)
                {
                    matrizResultado[i, j] = ((matriz[i, j - 1] - matriz[i - 1, j - 1]) / (xs[i] - xs[i - j]));

                }

            }

            return matrizResultado;
        }

        public int evaluarEnUnPunto(int[,] matriz, int n, int puntoAEvaluar, int[] xs)
        {
            int xt = 1;
            int yi = matriz[0, 0];

            for (int j = 0; j < n - 1; j++)
            {

                xt = xt * (puntoAEvaluar - xs[j]);
                yi = yi + matriz[0, j + 1] * xt;
            }

            return yi;
        }

        public String calcularPolinomioRegresivo(int[,] matrizDeDiferencias, int n, int[] xs)
        {
            //cambio el signo del vector
            int[] equis = (int[])xs.Clone();
            String signo = "";
            String xt = "";
            String signo2;
            String resultado = matrizDeDiferencias[n-1, 0].ToString();

            for (int i = 0; i < equis.Length; i++)
            {
                equis[i] = (-1) * xs[i];
            }



            for (int j = 1; j < n; j++)
            {
                signo = "";

                if (matrizDeDiferencias[n-1, j] > 0)
                {
                    signo = "+";
                }
                xt = "";
                
                for (int i = 0; i < j; i++)
                {
                    signo2 = "+";

                    if (equis[i] > 0)
                    {
                        signo2 = "+";
                    }

                    xt = xt + "*(x" + signo2 + equis[n-1-i].ToString() + ")";

                }

                resultado = resultado + signo + matrizDeDiferencias[n-1,j].ToString() + xt;

            }

            return resultado;

        }

    }
}

