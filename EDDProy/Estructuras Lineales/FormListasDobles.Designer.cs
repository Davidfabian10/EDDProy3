namespace EDDemo
{
    partial class FormListasDobles
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVaciarLista = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListaInversa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(194, 47);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(106, 34);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Lista";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(124, 134);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(218, 20);
            this.txtDato.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 170);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(124, 170);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 34);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(236, 170);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 34);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVaciarLista
            // 
            this.btnVaciarLista.Location = new System.Drawing.Point(348, 170);
            this.btnVaciarLista.Name = "btnVaciarLista";
            this.btnVaciarLista.Size = new System.Drawing.Size(106, 34);
            this.btnVaciarLista.TabIndex = 5;
            this.btnVaciarLista.Text = "Ver Lista";
            this.btnVaciarLista.UseVisualStyleBackColor = true;
            this.btnVaciarLista.Click += new System.EventHandler(this.btnVaciarLista_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(57, 296);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(350, 20);
            this.txtLista.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese dato:";
            // 
            // btnListaInversa
            // 
            this.btnListaInversa.Location = new System.Drawing.Point(194, 229);
            this.btnListaInversa.Name = "btnListaInversa";
            this.btnListaInversa.Size = new System.Drawing.Size(106, 34);
            this.btnListaInversa.TabIndex = 8;
            this.btnListaInversa.Text = "Ver Lista Inversa";
            this.btnListaInversa.UseVisualStyleBackColor = true;
            this.btnListaInversa.Click += new System.EventHandler(this.btnListaInversa_Click);
            // 
            // FormListasDobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.btnListaInversa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.btnVaciarLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnCrear);
            this.Name = "FormListasDobles";
            this.Text = "Listas Dobles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVaciarLista;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListaInversa;
    }
}