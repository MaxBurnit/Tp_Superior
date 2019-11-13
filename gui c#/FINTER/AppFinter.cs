using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FINTER.Calculos;

namespace FINTER
{
    public partial class AppFinter : Form
    {
        public AppFinter()
        {
            InitializeComponent();
            lblResultado.Hide();
            cmbMetodos.Items.Add("Lagrange");
            cmbMetodos.Items.Add("Newton-Gregory Progresivo");
            cmbMetodos.Items.Add("Newton-Gregory Regresivo");

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (cmbMetodos.SelectedItem.ToString() == "Newton-Gregory Progresivo") 
            {
                NewtonGregoryProg calculadora = new NewtonGregoryProg();


            
            }

        }
    }
}
