namespace EDDemo
{
    partial class FormTorresHanoi
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
            this.txtNumeroDiscos = new System.Windows.Forms.TextBox();
            this.btnCalcularTorresHanoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTiempoTorresHanoi = new System.Windows.Forms.Label();
            this.lblOperacionesTorresHanoi = new System.Windows.Forms.Label();
            this.lblResultadoTorresHanoi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce el numero de discos:";
            // 
            // txtNumeroDiscos
            // 
            this.txtNumeroDiscos.Location = new System.Drawing.Point(218, 70);
            this.txtNumeroDiscos.Name = "txtNumeroDiscos";
            this.txtNumeroDiscos.Size = new System.Drawing.Size(149, 20);
            this.txtNumeroDiscos.TabIndex = 1;
            // 
            // btnCalcularTorresHanoi
            // 
            this.btnCalcularTorresHanoi.Location = new System.Drawing.Point(247, 96);
            this.btnCalcularTorresHanoi.Name = "btnCalcularTorresHanoi";
            this.btnCalcularTorresHanoi.Size = new System.Drawing.Size(83, 29);
            this.btnCalcularTorresHanoi.TabIndex = 2;
            this.btnCalcularTorresHanoi.Text = "Calcular";
            this.btnCalcularTorresHanoi.UseVisualStyleBackColor = true;
            this.btnCalcularTorresHanoi.Click += new System.EventHandler(this.btnCalcularTorresHanoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo:";
            // 
            // lblTiempoTorresHanoi
            // 
            this.lblTiempoTorresHanoi.AutoSize = true;
            this.lblTiempoTorresHanoi.Location = new System.Drawing.Point(215, 187);
            this.lblTiempoTorresHanoi.Name = "lblTiempoTorresHanoi";
            this.lblTiempoTorresHanoi.Size = new System.Drawing.Size(0, 13);
            this.lblTiempoTorresHanoi.TabIndex = 4;
            // 
            // lblOperacionesTorresHanoi
            // 
            this.lblOperacionesTorresHanoi.AutoSize = true;
            this.lblOperacionesTorresHanoi.Location = new System.Drawing.Point(215, 254);
            this.lblOperacionesTorresHanoi.Name = "lblOperacionesTorresHanoi";
            this.lblOperacionesTorresHanoi.Size = new System.Drawing.Size(0, 13);
            this.lblOperacionesTorresHanoi.TabIndex = 5;
            // 
            // lblResultadoTorresHanoi
            // 
            this.lblResultadoTorresHanoi.AutoSize = true;
            this.lblResultadoTorresHanoi.Location = new System.Drawing.Point(215, 335);
            this.lblResultadoTorresHanoi.Name = "lblResultadoTorresHanoi";
            this.lblResultadoTorresHanoi.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoTorresHanoi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Operaciones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado:";
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(27, 58);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(169, 290);
            this.lstResultados.TabIndex = 9;
            // 
            // FormTorresHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultadoTorresHanoi);
            this.Controls.Add(this.lblOperacionesTorresHanoi);
            this.Controls.Add(this.lblTiempoTorresHanoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcularTorresHanoi);
            this.Controls.Add(this.txtNumeroDiscos);
            this.Controls.Add(this.label1);
            this.Name = "FormTorresHanoi";
            this.Text = "FormTorresHanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroDiscos;
        private System.Windows.Forms.Button btnCalcularTorresHanoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTiempoTorresHanoi;
        private System.Windows.Forms.Label lblOperacionesTorresHanoi;
        private System.Windows.Forms.Label lblResultadoTorresHanoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstResultados;
    }
}