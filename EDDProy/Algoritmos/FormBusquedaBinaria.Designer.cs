namespace EDDemo
{
    partial class FormBusquedaBinaria
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
            this.txtTamañoArreglo = new System.Windows.Forms.TextBox();
            this.btnGenerarArreglo = new System.Windows.Forms.Button();
            this.lstArreglo = new System.Windows.Forms.ListBox();
            this.txtValorBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResultadoBusqueda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTiempoBusqueda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOperacionesBusqueda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el tamaño del arreglo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el valor a buscar:";
            // 
            // txtTamañoArreglo
            // 
            this.txtTamañoArreglo.Location = new System.Drawing.Point(187, 62);
            this.txtTamañoArreglo.Name = "txtTamañoArreglo";
            this.txtTamañoArreglo.Size = new System.Drawing.Size(172, 20);
            this.txtTamañoArreglo.TabIndex = 2;
            // 
            // btnGenerarArreglo
            // 
            this.btnGenerarArreglo.Location = new System.Drawing.Point(233, 88);
            this.btnGenerarArreglo.Name = "btnGenerarArreglo";
            this.btnGenerarArreglo.Size = new System.Drawing.Size(82, 24);
            this.btnGenerarArreglo.TabIndex = 3;
            this.btnGenerarArreglo.Text = "Generar";
            this.btnGenerarArreglo.UseVisualStyleBackColor = true;
            // 
            // lstArreglo
            // 
            this.lstArreglo.FormattingEnabled = true;
            this.lstArreglo.Location = new System.Drawing.Point(25, 46);
            this.lstArreglo.Name = "lstArreglo";
            this.lstArreglo.Size = new System.Drawing.Size(153, 316);
            this.lstArreglo.TabIndex = 4;
            // 
            // txtValorBuscar
            // 
            this.txtValorBuscar.Location = new System.Drawing.Point(187, 166);
            this.txtValorBuscar.Name = "txtValorBuscar";
            this.txtValorBuscar.Size = new System.Drawing.Size(172, 20);
            this.txtValorBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(233, 192);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 24);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblResultadoBusqueda
            // 
            this.lblResultadoBusqueda.AutoSize = true;
            this.lblResultadoBusqueda.Location = new System.Drawing.Point(184, 253);
            this.lblResultadoBusqueda.Name = "lblResultadoBusqueda";
            this.lblResultadoBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoBusqueda.TabIndex = 7;
            this.lblResultadoBusqueda.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tiempo:";
            // 
            // lblTiempoBusqueda
            // 
            this.lblTiempoBusqueda.AutoSize = true;
            this.lblTiempoBusqueda.Location = new System.Drawing.Point(184, 298);
            this.lblTiempoBusqueda.Name = "lblTiempoBusqueda";
            this.lblTiempoBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblTiempoBusqueda.TabIndex = 10;
            this.lblTiempoBusqueda.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Operaciones:";
            // 
            // lblOperacionesBusqueda
            // 
            this.lblOperacionesBusqueda.AutoSize = true;
            this.lblOperacionesBusqueda.Location = new System.Drawing.Point(184, 343);
            this.lblOperacionesBusqueda.Name = "lblOperacionesBusqueda";
            this.lblOperacionesBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblOperacionesBusqueda.TabIndex = 12;
            this.lblOperacionesBusqueda.Text = "label5";
            // 
            // FormBusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.lblOperacionesBusqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTiempoBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultadoBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtValorBuscar);
            this.Controls.Add(this.lstArreglo);
            this.Controls.Add(this.btnGenerarArreglo);
            this.Controls.Add(this.txtTamañoArreglo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBusquedaBinaria";
            this.Text = "FormBusquedaBinaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamañoArreglo;
        private System.Windows.Forms.Button btnGenerarArreglo;
        private System.Windows.Forms.ListBox lstArreglo;
        private System.Windows.Forms.TextBox txtValorBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResultadoBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTiempoBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOperacionesBusqueda;
    }
}