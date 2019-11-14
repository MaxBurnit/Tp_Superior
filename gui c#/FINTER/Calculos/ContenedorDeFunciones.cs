using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINTER.Calculos
{
    class ContenedorDeFunciones
    {
        public int[,] tablaDeDiferenciasRegresivo(int[] xs, int tamanioVector, int[,] matriz)
        {
            int[,] matrizResultado = new int[tamanioVector, tamanioVector];
            matrizResultado = (int[,])matriz.Clone(); ////regresivo
            for (int j = 1; j < tamanioVector; j++)
            {
                for (int i = tamanioVector - 1; i >= j; i--)
                {
                    matrizResultado[i, j] = ((matriz[i, j - 1] - matriz[i - 1, j - 1]) / (xs[i] - xs[i - j]));

                }

            }

            return matrizResultado;
        }

        public int[,] tablaDeDiferenciasProgresivo(int[] xs, int tamanioVector, int[,] matriz)
        {
            int[,] matrizResultado = new int[tamanioVector, tamanioVector];
            matrizResultado = matriz;


            for (int j = 1; j < tamanioVector; j++)
            {
                for (int i = 0; i < tamanioVector - j; i++)
                {
                    matrizResultado[i, j] = ((matriz[i + 1, j - 1] - matriz[i, j - 1]) / (xs[i + j] - xs[i]));

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

        public String calcularPolinomioProgresivo(int[,] matrizDeDiferencias, int n, int[] xs)
        {
            //cambio el signo del vector
            int[] equis = (int[])xs.Clone();
            String signo = "";
            String xt = "";
            String signo2;
            String resultado = matrizDeDiferencias[0, 0].ToString();

            for (int i = 0; i < equis.Length; i++)
            {
                equis[i] = (-1) * xs[i];
            }



            for (int j = 1; j < n; j++)
            {
                if (matrizDeDiferencias[0, j] > 0)
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

                    xt = xt + "*(x" + signo2 + equis[i].ToString() + ")";

                }

                resultado = resultado + signo + matrizDeDiferencias[0, j].ToString() + xt;

            }

            return resultado;

        }

        public String calcularPolinomioRegresivo(int[,] matrizDeDiferencias, int n, int[] xs)
        {
            //cambio el signo del vector
            int[] equis = (int[])xs.Clone();
            String signo = "";
            String xt = "";
            String signo2;
            String resultado = matrizDeDiferencias[0, 0].ToString();

            for (int i = 0; i < equis.Length; i++)
            {
                equis[i] = (-1) * xs[i];
            }



            for (int j = 1; j < n; j++)
            {
                if (matrizDeDiferencias[0, j] > 0)
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

                    xt = xt + "*(x" + signo2 + equis[i].ToString() + ")";

                }

                resultado = resultado + signo + matrizDeDiferencias[0, j].ToString() + xt;

            }

            return resultado;

        }
	public static void calcularPolinomioLagrange(int[] x,int[] y, int xi){
		int[] equis = (int[])x.Clone();
		int sm = 0;
		for(int i = 0; i <= (equis.Length- 1); i++){
			int pr = 1;
			for(int j = 0; j <= (equis.Length- 1); j++){
				if (j != i){
					pr = pr * (xi - x[j])/(x[i] - x[j]);
				}
			}
			sm = sm + (y[i] * pr);
		}
		Console.WriteLine(sm);
	}
	public static void mostrarPolinomiosLagrange(int[] x){
		int n = x.Length;
		string s = x.ToString();
		for(int i = 0; i < n; i++){
			string numerador = " ";
			string denominador = " ";
			string polinomio = " ";
			int den = 1; 
			for(int j = 0; j < n; j++){
				if(j != i){
					numerador = numerador + "(x-(" + x[j].ToString() +"))"; 
					den = den * (x[i] - x[j]); 
					denominador = den.ToString();  
				}
			} 
			polinomio = "L(" + i.ToString() +")=" + numerador + "/" + denominador; 
			Console.WriteLine(polinomio);
		}
	}
}
