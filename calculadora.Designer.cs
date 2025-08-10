namespace Calculadora_4_operaciones
{
    partial class calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labeltotal = new Label();
            buttonSuma = new Button();
            buttonResta = new Button();
            buttonMultiplicacion = new Button();
            buttonDivision = new Button();
            textBox1 = new TextBox();
            labelnumero1 = new Label();
            labelnumero2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.Location = new Point(279, 180);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(62, 15);
            labeltotal.TabIndex = 0;
            labeltotal.Text = "Resultado:";
            // 
            // buttonSuma
            // 
            buttonSuma.Location = new Point(107, 222);
            buttonSuma.Name = "buttonSuma";
            buttonSuma.Size = new Size(89, 32);
            buttonSuma.TabIndex = 1;
            buttonSuma.Text = "Suma";
            buttonSuma.UseVisualStyleBackColor = true;
            buttonSuma.Click += buttonSuma_Click;
            // 
            // buttonResta
            // 
            buttonResta.Location = new Point(257, 222);
            buttonResta.Name = "buttonResta";
            buttonResta.Size = new Size(85, 32);
            buttonResta.TabIndex = 2;
            buttonResta.Text = "Resta";
            buttonResta.UseVisualStyleBackColor = true;
            buttonResta.Click += buttonResta_Click;
            // 
            // buttonMultiplicacion
            // 
            buttonMultiplicacion.Location = new Point(371, 222);
            buttonMultiplicacion.Name = "buttonMultiplicacion";
            buttonMultiplicacion.Size = new Size(95, 32);
            buttonMultiplicacion.TabIndex = 3;
            buttonMultiplicacion.Text = "Multiplicacion";
            buttonMultiplicacion.UseVisualStyleBackColor = true;
            buttonMultiplicacion.Click += buttonMultiplicacion_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.Location = new Point(525, 222);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(98, 30);
            buttonDivision.TabIndex = 4;
            buttonDivision.Text = "Division";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 5;
            // 
            // labelnumero1
            // 
            labelnumero1.AutoSize = true;
            labelnumero1.Location = new Point(119, 80);
            labelnumero1.Name = "labelnumero1";
            labelnumero1.Size = new Size(49, 15);
            labelnumero1.TabIndex = 6;
            labelnumero1.Text = "numero";
            // 
            // labelnumero2
            // 
            labelnumero2.AutoSize = true;
            labelnumero2.Location = new Point(326, 80);
            labelnumero2.Name = "labelnumero2";
            labelnumero2.Size = new Size(49, 15);
            labelnumero2.TabIndex = 7;
            labelnumero2.Text = "numero";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 23);
            textBox2.TabIndex = 8;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(labelnumero2);
            Controls.Add(labelnumero1);
            Controls.Add(textBox1);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMultiplicacion);
            Controls.Add(buttonResta);
            Controls.Add(buttonSuma);
            Controls.Add(labeltotal);
            Name = "calculadora";
            Text = "calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeltotal;
        private Button buttonSuma;
        private Button buttonResta;
        private Button buttonMultiplicacion;
        private Button buttonDivision;
        private TextBox textBox1;
        private Label labelnumero1;
        private Label labelnumero2;
        private TextBox textBox2;
    }
}
