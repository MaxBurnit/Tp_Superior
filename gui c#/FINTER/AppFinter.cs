﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FINTER.Calculos;
using FINTER.Pasos;

namespace FINTER
{
    public partial class AppFinter : Form
    {
        public AppFinter()
        {
            InitializeComponent();
            cmbMetodos.Items.Add("Lagrange");
            cmbMetodos.Items.Add("Newton-Gregory Progresivo");
            cmbMetodos.Items.Add("Newton-Gregory Regresivo");
            gbox2.Visible = false;
            gbox1.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int[] xIngresados = Array.ConvertAll(txtXs.Text.Split(','), s => int.Parse(s));
            int[] yIngresados = Array.ConvertAll(txtYs.Text.Split(','), s => int.Parse(s));

            int[,] matrizAux = new int[xIngresados.Length, yIngresados.Length];
            int gradoPolinomio = xIngresados.Length - 1;
            lblGradoPolinomio.Text = "Grado de P(x): " + gradoPolinomio.ToString();
            lblPuntosEquiespaciados.Text = "Puntos equiespaciados: " + ContenedorDeFunciones.sonEquidistantes(xIngresados,
                yIngresados);

            //asigno todas las ys en la primer columna de la matriz

            for (int i = 0; i < yIngresados.Length; i++)
            {

                matrizAux[i, 0] = yIngresados[i];

            }

            if (cmbMetodos.SelectedItem.ToString() == "Newton-Gregory Progresivo")
            {

                NewtonGregoryProg calculador = new NewtonGregoryProg();

                int[,] matrizDeDiferencias = calculador
                    .tablaDeDiferenciasProgresivo(xIngresados, xIngresados.Length, matrizAux);
                String resultadoPolinomio = calculador.calcularPolinomioProgresivo(matrizDeDiferencias, xIngresados.Length, xIngresados);

                lblResultado.Text = "P(x)= " + resultadoPolinomio;

                gbox1.Visible = true;
                gbox2.Visible = true;
            }

            if (cmbMetodos.SelectedItem.ToString() == "Newton-Gregory Regresivo")
            {

                NewtonGregoryReg calculador = new NewtonGregoryReg();

                int[,] matrizDeDiferencias = calculador
                    .tablaDeDiferenciasRegresivo(xIngresados, xIngresados.Length, matrizAux);
                String resultadoPolinomio = calculador.calcularPolinomioRegresivo(matrizDeDiferencias, xIngresados.Length, xIngresados);

                lblResultado.Text = "P(x)= " + resultadoPolinomio;

                gbox1.Visible = true;
                gbox2.Visible = true;
            }

            if (cmbMetodos.SelectedItem.ToString() == "Lagrange")
            {

                Lagrange calculador = new Lagrange();

                String resultadoPolinomio = calculador.polinomioFinal(xIngresados, yIngresados);

                lblResultado.Text = "P(x)= " + resultadoPolinomio;

                gbox1.Visible = true;
                gbox2.Visible = true;
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {

            int[] xIngresados = Array.ConvertAll(txtXs.Text.Split(','), s => int.Parse(s));
            int[] yIngresados = Array.ConvertAll(txtYs.Text.Split(','), s => int.Parse(s));

            int[,] matrizAux = new int[xIngresados.Length, yIngresados.Length];
            
            for (int i = 0; i < yIngresados.Length; i++)
            {

                matrizAux[i, 0] = yIngresados[i];

            }

            if (cmbMetodos.SelectedItem.ToString() == "Newton-Gregory Progresivo")
            {

                NewtonGregoryProg calculador = new NewtonGregoryProg();

                int[,] matrizDeDiferencias = calculador
                    .tablaDeDiferenciasProgresivo(xIngresados, xIngresados.Length, matrizAux);
                int resultadoPunto = calculador.evaluarEnUnPunto(matrizAux, xIngresados.Length, int.Parse(txtPunto.Text),xIngresados);
                lblResultadoPunto.Text = "P(" + txtPunto.Text + ")= " + resultadoPunto.ToString();

                gbox1.Visible = true;
                gbox2.Visible = true;
            }


            if (cmbMetodos.SelectedItem.ToString() == "Newton-Gregory Regresivo")
            {

                NewtonGregoryReg calculador = new NewtonGregoryReg();

                int[,] matrizDeDiferencias = calculador
                    .tablaDeDiferenciasRegresivo(xIngresados, xIngresados.Length, matrizAux);
                int resultadoPunto = calculador.evaluarEnUnPunto(matrizAux, xIngresados.Length, int.Parse(txtPunto.Text), xIngresados);
                lblResultadoPunto.Text = "P(" + txtPunto.Text + ")= " + resultadoPunto.ToString();

                gbox1.Visible = true;
                gbox2.Visible = true;
            }


            if (cmbMetodos.SelectedItem.ToString() == "Lagrange")
            {

                Lagrange calculador = new Lagrange();
                int resultadoPunto = calculador.calcularPolinomioLagrange(xIngresados, yIngresados, int.Parse(txtPunto.Text));
                lblResultadoPunto.Text = "P(" + txtPunto.Text + ")= " + resultadoPunto.ToString();

                gbox1.Visible = true;
                gbox2.Visible = true;
            }

        }

        private void btnPasosCalculo_Click(object sender, EventArgs e)
        {
            int[] xIngresados = Array.ConvertAll(txtXs.Text.Split(','), s => int.Parse(s));
            int[] yIngresados = Array.ConvertAll(txtYs.Text.Split(','), s => int.Parse(s));

            int[,] matrizAux = new int[xIngresados.Length, yIngresados.Length];

            for (int i = 0; i < yIngresados.Length; i++)
            {

                matrizAux[i, 0] = yIngresados[i];

            }

            if (cmbMetodos.SelectedItem.ToString() == "Newton-Gregory Progresivo")
            {
                NewtonGregoryProg calculador = new NewtonGregoryProg();
                int[,] matrizDiferencias = calculador.tablaDeDiferenciasProgresivo(xIngresados, xIngresados.Length, matrizAux);

                Form pantallaPasos = new PasosNewtonProgForm(matrizDiferencias);
                pantallaPasos.Show();

            }

            if (cmbMetodos.SelectedItem.ToString() == "Newton-Gregory Regresivo")
            {
                NewtonGregoryReg calculador = new NewtonGregoryReg();
                int[,] matrizDiferencias = calculador.tablaDeDiferenciasRegresivo(xIngresados, xIngresados.Length, matrizAux);

                Form pantallaPasos = new PasosNewtonRegForm(matrizDiferencias);
                pantallaPasos.Show();

            }


            if (cmbMetodos.SelectedItem.ToString() == "Lagrange")
            {
                Lagrange calculador = new Lagrange();
                String polinomios = calculador.mostrarPolinomiosLagrange(xIngresados);

                Form pantallaPasos = new LagrangeForm(polinomios, xIngresados.Length);
                pantallaPasos.Show();

            }

        }
    }
}
