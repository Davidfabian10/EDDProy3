namespace EDDemo
{
    partial class FormExponente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaseExponente = new System.Windows.Forms.TextBox();
            this.txtExponenteInput = new System.Windows.Forms.TextBox();
            this.btCalcularExponente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultadoExponente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTiempoExponente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOperacionesExponente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa la base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el exponenete:";
            // 
            // txtBaseExponente
            // 
            this.txtBaseExponente.Location = new System.Drawing.Point(182, 66);
            this.txtBaseExponente.Name = "txtBaseExponente";
            this.txtBaseExponente.Size = new System.Drawing.Size(172, 20);
            this.txtBaseExponente.TabIndex = 2;
            // 
            // txtExponenteInput
            // 
            this.txtExponenteInput.Location = new System.Drawing.Point(182, 129);
            this.txtExponenteInput.Name = "txtExponenteInput";
            this.txtExponenteInput.Size = new System.Drawing.Size(172, 20);
            this.txtExponenteInput.TabIndex = 3;
            // 
            // btCalcularExponente
            // 
            this.btCalcularExponente.Location = new System.Drawing.Point(220, 169);
            this.btCalcularExponente.Name = "btCalcularExponente";
            this.btCalcularExponente.Size = new System.Drawing.Size(88, 24);
            this.btCalcularExponente.TabIndex = 4;
            this.btCalcularExponente.Text = "Calcular";
            this.btCalcularExponente.UseVisualStyleBackColor = true;
            this.btCalcularExponente.Click += new System.EventHandler(this.btCalcularExponente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resulado:";
            // 
            // lblResultadoExponente
            // 
            this.lblResultadoExponente.AutoSize = true;
            this.lblResultadoExponente.Location = new System.Drawing.Point(179, 242);
            this.lblResultadoExponente.Name = "lblResultadoExponente";
            this.lblResultadoExponente.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoExponente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiempo de Ejecucion:";
            // 
            // lblTiempoExponente
            // 
            this.lblTiempoExponente.AutoSize = true;
            this.lblTiempoExponente.Location = new System.Drawing.Point(179, 293);
            this.lblTiempoExponente.Name = "lblTiempoExponente";
            this.lblTiempoExponente.Size = new System.Drawing.Size(0, 13);
            this.lblTiempoExponente.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operaciones Realizadas:";
            // 
            // lblOperacionesExponente
            // 
            this.lblOperacionesExponente.AutoSize = true;
            this.lblOperacionesExponente.Location = new System.Drawing.Point(179, 339);
            this.lblOperacionesExponente.Name = "lblOperacionesExponente";
            this.lblOperacionesExponente.Size = new System.Drawing.Size(0, 13);
            this.lblOperacionesExponente.TabIndex = 10;
            // 
            // FormExponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.lblOperacionesExponente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTiempoExponente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultadoExponente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCalcularExponente);
            this.Controls.Add(this.txtExponenteInput);
            this.Controls.Add(this.txtBaseExponente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormExponente";
            this.Text = "FormExponente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaseExponente;
        private System.Windows.Forms.TextBox txtExponenteInput;
        private System.Windows.Forms.Button btCalcularExponente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultadoExponente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTiempoExponente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOperacionesExponente;
    }
}