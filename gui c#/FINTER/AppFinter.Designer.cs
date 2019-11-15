namespace FINTER
{
    partial class AppFinter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtXs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYs = new System.Windows.Forms.TextBox();
            this.cmbMetodos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.lblGradoPolinomio = new System.Windows.Forms.Label();
            this.lblPuntosEquiespaciados = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.txtPunto = new System.Windows.Forms.TextBox();
            this.lblResultadoPunto = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPasosCalculo = new System.Windows.Forms.Button();
            this.gbox1.SuspendLayout();
            this.gbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtXs
            // 
            this.txtXs.Location = new System.Drawing.Point(321, 41);
            this.txtXs.Name = "txtXs";
            this.txtXs.Size = new System.Drawing.Size(175, 22);
            this.txtXs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese valores de x (seguidos de una coma)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese valores de y (seguidos de una coma)";
            // 
            // txtYs
            // 
            this.txtYs.Location = new System.Drawing.Point(321, 93);
            this.txtYs.Name = "txtYs";
            this.txtYs.Size = new System.Drawing.Size(175, 22);
            this.txtYs.TabIndex = 4;
            // 
            // cmbMetodos
            // 
            this.cmbMetodos.FormattingEnabled = true;
            this.cmbMetodos.Location = new System.Drawing.Point(321, 139);
            this.cmbMetodos.Name = "cmbMetodos";
            this.cmbMetodos.Size = new System.Drawing.Size(175, 24);
            this.cmbMetodos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccion metodo de interpolacion";
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.lblGradoPolinomio);
            this.gbox1.Controls.Add(this.lblPuntosEquiespaciados);
            this.gbox1.Controls.Add(this.lblResultado);
            this.gbox1.Location = new System.Drawing.Point(12, 195);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(496, 124);
            this.gbox1.TabIndex = 7;
            this.gbox1.TabStop = false;
            // 
            // lblGradoPolinomio
            // 
            this.lblGradoPolinomio.AutoSize = true;
            this.lblGradoPolinomio.Location = new System.Drawing.Point(6, 91);
            this.lblGradoPolinomio.Name = "lblGradoPolinomio";
            this.lblGradoPolinomio.Size = new System.Drawing.Size(97, 17);
            this.lblGradoPolinomio.TabIndex = 3;
            this.lblGradoPolinomio.Text = "Grado de P(x)";
            // 
            // lblPuntosEquiespaciados
            // 
            this.lblPuntosEquiespaciados.AutoSize = true;
            this.lblPuntosEquiespaciados.Location = new System.Drawing.Point(6, 54);
            this.lblPuntosEquiespaciados.Name = "lblPuntosEquiespaciados";
            this.lblPuntosEquiespaciados.Size = new System.Drawing.Size(159, 17);
            this.lblPuntosEquiespaciados.TabIndex = 2;
            this.lblPuntosEquiespaciados.Text = "Puntos equiespaciados:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(6, 18);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(76, 17);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(524, 201);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 118);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbox2
            // 
            this.gbox2.Controls.Add(this.txtPunto);
            this.gbox2.Controls.Add(this.lblResultadoPunto);
            this.gbox2.Controls.Add(this.btnEvaluar);
            this.gbox2.Controls.Add(this.label4);
            this.gbox2.Controls.Add(this.btnPasosCalculo);
            this.gbox2.Location = new System.Drawing.Point(15, 325);
            this.gbox2.Name = "gbox2";
            this.gbox2.Size = new System.Drawing.Size(676, 169);
            this.gbox2.TabIndex = 10;
            this.gbox2.TabStop = false;
            // 
            // txtPunto
            // 
            this.txtPunto.Location = new System.Drawing.Point(225, 42);
            this.txtPunto.Name = "txtPunto";
            this.txtPunto.Size = new System.Drawing.Size(176, 22);
            this.txtPunto.TabIndex = 4;
            // 
            // lblResultadoPunto
            // 
            this.lblResultadoPunto.AutoSize = true;
            this.lblResultadoPunto.Location = new System.Drawing.Point(125, 100);
            this.lblResultadoPunto.Name = "lblResultadoPunto";
            this.lblResultadoPunto.Size = new System.Drawing.Size(71, 17);
            this.lblResultadoPunto.TabIndex = 3;
            this.lblResultadoPunto.Text = "resultado:";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(506, 23);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(153, 55);
            this.btnEvaluar.TabIndex = 2;
            this.btnEvaluar.Text = "EVALUAR";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Evaluar P(x) en un valor k";
            // 
            // btnPasosCalculo
            // 
            this.btnPasosCalculo.Location = new System.Drawing.Point(506, 100);
            this.btnPasosCalculo.Name = "btnPasosCalculo";
            this.btnPasosCalculo.Size = new System.Drawing.Size(153, 58);
            this.btnPasosCalculo.TabIndex = 0;
            this.btnPasosCalculo.Text = "MOSTRAR PASOS DE CALCULO";
            this.btnPasosCalculo.UseVisualStyleBackColor = true;
            this.btnPasosCalculo.Click += new System.EventHandler(this.btnPasosCalculo_Click);
            // 
            // AppFinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 521);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMetodos);
            this.Controls.Add(this.txtYs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXs);
            this.Name = "AppFinter";
            this.Text = "FINTER";
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            this.gbox2.ResumeLayout(false);
            this.gbox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtXs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYs;
        private System.Windows.Forms.ComboBox cmbMetodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPuntosEquiespaciados;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox gbox2;
        private System.Windows.Forms.TextBox txtPunto;
        private System.Windows.Forms.Label lblResultadoPunto;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPasosCalculo;
        private System.Windows.Forms.Label lblGradoPolinomio;
    }
}

