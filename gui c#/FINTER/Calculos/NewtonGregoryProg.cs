﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINTER.Calculos
{
    class NewtonGregoryProg
    { 
        public int[,] tablaDeDiferenciasProgresivo(int[] xs, int tamanioVector, int[,] matriz)
        {
            //int[,] matrizResultado = new int[tamanioVector, tamanioVector];
            int[,]matrizResultado = matriz;


            for (int j = 1; j < tamanioVector; j++)
            {
                for (int i = 0; i < tamanioVector - j; i++)
                {
                    matrizResultado[i, j] = ((matriz[i + 1, j - 1] - matriz[i, j - 1]) / (xs[i + j] - xs[i]));

                }

            }

            return matrizResultado;
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

    }
}
