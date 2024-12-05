namespace EDDemo
{
    partial class FormSumarArreglo
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
            this.txtTamañoArreglo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtElementosArreglo = new System.Windows.Forms.TextBox();
            this.btnCalcularSumaArreglo = new System.Windows.Forms.Button();
            this.lblResultadoSuma = new System.Windows.Forms.Label();
            this.lblTiempoSuma = new System.Windows.Forms.Label();
            this.lblOperacionesSuma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTamañoArreglo
            // 
            this.txtTamañoArreglo.Location = new System.Drawing.Point(135, 73);
            this.txtTamañoArreglo.Name = "txtTamañoArreglo";
            this.txtTamañoArreglo.Size = new System.Drawing.Size(193, 20);
            this.txtTamañoArreglo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa el tamaño del arreglo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa los elementos del arreglo: (separados por ,)";
            // 
            // txtElementosArreglo
            // 
            this.txtElementosArreglo.Location = new System.Drawing.Point(135, 180);
            this.txtElementosArreglo.Name = "txtElementosArreglo";
            this.txtElementosArreglo.Size = new System.Drawing.Size(193, 20);
            this.txtElementosArreglo.TabIndex = 4;
            // 
            // btnCalcularSumaArreglo
            // 
            this.btnCalcularSumaArreglo.Location = new System.Drawing.Point(180, 221);
            this.btnCalcularSumaArreglo.Name = "btnCalcularSumaArreglo";
            this.btnCalcularSumaArreglo.Size = new System.Drawing.Size(85, 32);
            this.btnCalcularSumaArreglo.TabIndex = 5;
            this.btnCalcularSumaArreglo.Text = "Calcular Suma";
            this.btnCalcularSumaArreglo.UseVisualStyleBackColor = true;
            this.btnCalcularSumaArreglo.Click += new System.EventHandler(this.btnCalcularSumaArreglo_Click);
            // 
            // lblResultadoSuma
            // 
            this.lblResultadoSuma.AutoSize = true;
            this.lblResultadoSuma.Location = new System.Drawing.Point(205, 290);
            this.lblResultadoSuma.Name = "lblResultadoSuma";
            this.lblResultadoSuma.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoSuma.TabIndex = 6;
            // 
            // lblTiempoSuma
            // 
            this.lblTiempoSuma.AutoSize = true;
            this.lblTiempoSuma.Location = new System.Drawing.Point(205, 342);
            this.lblTiempoSuma.Name = "lblTiempoSuma";
            this.lblTiempoSuma.Size = new System.Drawing.Size(0, 13);
            this.lblTiempoSuma.TabIndex = 7;
            // 
            // lblOperacionesSuma
            // 
            this.lblOperacionesSuma.AutoSize = true;
            this.lblOperacionesSuma.Location = new System.Drawing.Point(205, 396);
            this.lblOperacionesSuma.Name = "lblOperacionesSuma";
            this.lblOperacionesSuma.Size = new System.Drawing.Size(0, 13);
            this.lblOperacionesSuma.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tiempo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Operaciones:";
            // 
            // FormSumarArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOperacionesSuma);
            this.Controls.Add(this.lblTiempoSuma);
            this.Controls.Add(this.lblResultadoSuma);
            this.Controls.Add(this.btnCalcularSumaArreglo);
            this.Controls.Add(this.txtElementosArreglo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamañoArreglo);
            this.Name = "FormSumarArreglo";
            this.Text = "Sumar Arreglo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTamañoArreglo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElementosArreglo;
        private System.Windows.Forms.Button btnCalcularSumaArreglo;
        private System.Windows.Forms.Label lblResultadoSuma;
        private System.Windows.Forms.Label lblTiempoSuma;
        private System.Windows.Forms.Label lblOperacionesSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}