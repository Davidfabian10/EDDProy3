namespace EDDemo
{
    partial class FormFactorial
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
            this.txtFactorialInput = new System.Windows.Forms.TextBox();
            this.btnCalcularFactorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultadoFactorial = new System.Windows.Forms.Label();
            this.lblTiempoFactorial = new System.Windows.Forms.Label();
            this.lblOperacionesFactorial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFactorialInput
            // 
            this.txtFactorialInput.Location = new System.Drawing.Point(112, 55);
            this.txtFactorialInput.Name = "txtFactorialInput";
            this.txtFactorialInput.Size = new System.Drawing.Size(168, 20);
            this.txtFactorialInput.TabIndex = 0;
            // 
            // btnCalcularFactorial
            // 
            this.btnCalcularFactorial.Location = new System.Drawing.Point(157, 99);
            this.btnCalcularFactorial.Name = "btnCalcularFactorial";
            this.btnCalcularFactorial.Size = new System.Drawing.Size(74, 30);
            this.btnCalcularFactorial.TabIndex = 1;
            this.btnCalcularFactorial.Text = "Calcular";
            this.btnCalcularFactorial.UseVisualStyleBackColor = true;
            this.btnCalcularFactorial.Click += new System.EventHandler(this.btnCalcularFactorial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduce un numero:";
            // 
            // lblResultadoFactorial
            // 
            this.lblResultadoFactorial.AutoSize = true;
            this.lblResultadoFactorial.Location = new System.Drawing.Point(109, 202);
            this.lblResultadoFactorial.Name = "lblResultadoFactorial";
            this.lblResultadoFactorial.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoFactorial.TabIndex = 3;
            // 
            // lblTiempoFactorial
            // 
            this.lblTiempoFactorial.AutoSize = true;
            this.lblTiempoFactorial.Location = new System.Drawing.Point(109, 282);
            this.lblTiempoFactorial.Name = "lblTiempoFactorial";
            this.lblTiempoFactorial.Size = new System.Drawing.Size(0, 13);
            this.lblTiempoFactorial.TabIndex = 4;
            // 
            // lblOperacionesFactorial
            // 
            this.lblOperacionesFactorial.AutoSize = true;
            this.lblOperacionesFactorial.Location = new System.Drawing.Point(109, 357);
            this.lblOperacionesFactorial.Name = "lblOperacionesFactorial";
            this.lblOperacionesFactorial.Size = new System.Drawing.Size(0, 13);
            this.lblOperacionesFactorial.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tiempo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Operaciones:";
            // 
            // FormFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperacionesFactorial);
            this.Controls.Add(this.lblTiempoFactorial);
            this.Controls.Add(this.lblResultadoFactorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularFactorial);
            this.Controls.Add(this.txtFactorialInput);
            this.Name = "FormFactorial";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFactorialInput;
        private System.Windows.Forms.Button btnCalcularFactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoFactorial;
        private System.Windows.Forms.Label lblTiempoFactorial;
        private System.Windows.Forms.Label lblOperacionesFactorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}