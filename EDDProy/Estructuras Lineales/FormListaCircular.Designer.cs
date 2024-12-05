namespace EDDemo
{
    partial class FormListaCircular
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
            this.BtCrear = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtVerLista = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtCrear
            // 
            this.BtCrear.Location = new System.Drawing.Point(190, 34);
            this.BtCrear.Name = "BtCrear";
            this.BtCrear.Size = new System.Drawing.Size(94, 31);
            this.BtCrear.TabIndex = 0;
            this.BtCrear.Text = "Crear Lista";
            this.BtCrear.UseVisualStyleBackColor = true;
            this.BtCrear.Click += new System.EventHandler(this.BtCrear_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(103, 119);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(267, 20);
            this.txtDato.TabIndex = 1;
            // 
            // BtAgregar
            // 
            this.BtAgregar.Location = new System.Drawing.Point(12, 164);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(94, 31);
            this.BtAgregar.TabIndex = 2;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = true;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(139, 164);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(94, 31);
            this.BtEliminar.TabIndex = 3;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(261, 164);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(94, 31);
            this.BtBuscar.TabIndex = 4;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtVerLista
            // 
            this.BtVerLista.Location = new System.Drawing.Point(379, 164);
            this.BtVerLista.Name = "BtVerLista";
            this.BtVerLista.Size = new System.Drawing.Size(94, 31);
            this.BtVerLista.TabIndex = 5;
            this.BtVerLista.Text = "Ver Lista";
            this.BtVerLista.UseVisualStyleBackColor = true;
            this.BtVerLista.Click += new System.EventHandler(this.BtVerLista_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(42, 246);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(394, 20);
            this.txtLista.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese dato:";
            // 
            // FormListaCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.BtVerLista);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtAgregar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.BtCrear);
            this.Name = "FormListaCircular";
            this.Text = "Lista Circular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCrear;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtVerLista;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label1;
    }
}