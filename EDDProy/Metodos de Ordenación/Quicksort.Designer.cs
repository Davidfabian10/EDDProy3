namespace EDDemo.Forms
{
    partial class frmQuickSort
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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.tbnOrdenar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los numeros a ordenar (seprados por ,) :";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(166, 104);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(228, 20);
            this.txtNumeros.TabIndex = 1;
            // 
            // tbnOrdenar
            // 
            this.tbnOrdenar.Location = new System.Drawing.Point(230, 141);
            this.tbnOrdenar.Name = "tbnOrdenar";
            this.tbnOrdenar.Size = new System.Drawing.Size(97, 32);
            this.tbnOrdenar.TabIndex = 2;
            this.tbnOrdenar.Text = "Ordenar";
            this.tbnOrdenar.UseVisualStyleBackColor = true;
            this.tbnOrdenar.Click += new System.EventHandler(this.tbnOrdenar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(166, 224);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(228, 134);
            this.lstResultado.TabIndex = 3;
            // 
            // frmQuickSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.tbnOrdenar);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label1);
            this.Name = "frmQuickSort";
            this.Text = "Quicksort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button tbnOrdenar;
        private System.Windows.Forms.ListBox lstResultado;
    }
}