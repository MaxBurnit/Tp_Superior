using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINTER.Pasos
{
    public partial class LagrangeForm : Form
    {
        public LagrangeForm(String polinomiosJuntos, int cantidadPolinomios)
        { 
            InitializeComponent();
            String[] polinomiosLagrange = polinomiosJuntos.Split('$');
            String polinomiosFinal = "";

            for(int i= 0; i < cantidadPolinomios; i++)
            {
                polinomiosFinal = polinomiosFinal + polinomiosLagrange[i] + ";\r\n";
            }

            lblPolinomiosLagrange.Text = polinomiosFinal;


        }
    }
}
