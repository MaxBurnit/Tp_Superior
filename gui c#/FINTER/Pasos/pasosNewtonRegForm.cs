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
    public partial class PasosNewtonRegForm : Form
    {
        int[,] matrizDiferencias;
        public PasosNewtonRegForm(int[,] matriz)
        {
            InitializeComponent();

            this.matrizDiferencias = matriz;

            int altura = matriz.GetLength(0);
            int ancho = matriz.GetLength(1);

            gridDiferencias.ColumnCount = ancho;

            for (int r = 0; r < altura; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gridDiferencias);

                for (int c = 0; c < ancho; c++)
                {
                    row.Cells[c].Value = matriz[r, c];
                }

                gridDiferencias.Rows.Add(row);
            }

        }
    }
}
