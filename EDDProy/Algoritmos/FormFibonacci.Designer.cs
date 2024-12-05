namespace EDDemo
{
    partial class FormFibonacci
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFibonacciInput = new System.Windows.Forms.TextBox();
            this.btnCalcularFibonacci = new System.Windows.Forms.Button();
            this.lblResultadoFibonacci = new System.Windows.Forms.Label();
            this.lblTiempoFibonacci = new System.Windows.Forms.Label();
            this.lblOperacionesFibonacci = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero para calcular:";
            // 
            // txtFibonacciInput
            // 
            this.txtFibonacciInput.Location = new System.Drawing.Point(157, 76);
            this.txtFibonacciInput.Name = "txtFibonacciInput";
            this.txtFibonacciInput.Size = new System.Drawing.Size(159, 20);
            this.txtFibonacciInput.TabIndex = 1;
            // 
            // btnCalcularFibonacci
            // 
            this.btnCalcularFibonacci.Location = new System.Drawing.Point(196, 114);
            this.btnCalcularFibonacci.Name = "btnCalcularFibonacci";
            this.btnCalcularFibonacci.Size = new System.Drawing.Size(82, 25);
            this.btnCalcularFibonacci.TabIndex = 2;
            this.btnCalcularFibonacci.Text = "Calcular";
            this.btnCalcularFibonacci.UseVisualStyleBackColor = true;
            this.btnCalcularFibonacci.Click += new System.EventHandler(this.btnCalcularFibonacci_Click);
            // 
            // lblResultadoFibonacci
            // 
            this.lblResultadoFibonacci.AutoSize = true;
            this.lblResultadoFibonacci.Location = new System.Drawing.Point(216, 203);
            this.lblResultadoFibonacci.Name = "lblResultadoFibonacci";
            this.lblResultadoFibonacci.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoFibonacci.TabIndex = 3;
            // 
            // lblTiempoFibonacci
            // 
            this.lblTiempoFibonacci.AutoSize = true;
            this.lblTiempoFibonacci.Location = new System.Drawing.Point(216, 282);
            this.lblTiempoFibonacci.Name = "lblTiempoFibonacci";
            this.lblTiempoFibonacci.Size = new System.Drawing.Size(0, 13);
            this.lblTiempoFibonacci.TabIndex = 4;
            // 
            // lblOperacionesFibonacci
            // 
            this.lblOperacionesFibonacci.AutoSize = true;
            this.lblOperacionesFibonacci.Location = new System.Drawing.Point(216, 358);
            this.lblOperacionesFibonacci.Name = "lblOperacionesFibonacci";
            this.lblOperacionesFibonacci.Size = new System.Drawing.Size(0, 13);
            this.lblOperacionesFibonacci.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tiempo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Operaciones:";
            // 
            // FormFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperacionesFibonacci);
            this.Controls.Add(this.lblTiempoFibonacci);
            this.Controls.Add(this.lblResultadoFibonacci);
            this.Controls.Add(this.btnCalcularFibonacci);
            this.Controls.Add(this.txtFibonacciInput);
            this.Controls.Add(this.label1);
            this.Name = "FormFibonacci";
            this.Text = "FormFibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFibonacciInput;
        private System.Windows.Forms.Button btnCalcularFibonacci;
        private System.Windows.Forms.Label lblResultadoFibonacci;
        private System.Windows.Forms.Label lblTiempoFibonacci;
        private System.Windows.Forms.Label lblOperacionesFibonacci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}