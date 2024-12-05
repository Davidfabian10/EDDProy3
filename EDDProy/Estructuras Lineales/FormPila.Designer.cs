namespace EDDemo
{
    partial class FormPila
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
            this.ListPila = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxPila = new System.Windows.Forms.TextBox();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTop = new System.Windows.Forms.Label();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListPila
            // 
            this.ListPila.FormattingEnabled = true;
            this.ListPila.Location = new System.Drawing.Point(39, 54);
            this.ListPila.Name = "ListPila";
            this.ListPila.Size = new System.Drawing.Size(157, 316);
            this.ListPila.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese dato:";
            // 
            // TxPila
            // 
            this.TxPila.Location = new System.Drawing.Point(214, 70);
            this.TxPila.Name = "TxPila";
            this.TxPila.Size = new System.Drawing.Size(221, 20);
            this.TxPila.TabIndex = 2;
            // 
            // BtAgregar
            // 
            this.BtAgregar.Location = new System.Drawing.Point(214, 114);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(99, 29);
            this.BtAgregar.TabIndex = 3;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = true;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(337, 114);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(98, 29);
            this.BtEliminar.TabIndex = 4;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOP de pila:";
            // 
            // LbTop
            // 
            this.LbTop.AutoSize = true;
            this.LbTop.Location = new System.Drawing.Point(211, 275);
            this.LbTop.Name = "LbTop";
            this.LbTop.Size = new System.Drawing.Size(0, 13);
            this.LbTop.TabIndex = 6;
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(214, 161);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(99, 29);
            this.BtBuscar.TabIndex = 7;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtVaciar
            // 
            this.BtVaciar.Location = new System.Drawing.Point(337, 161);
            this.BtVaciar.Name = "BtVaciar";
            this.BtVaciar.Size = new System.Drawing.Size(99, 29);
            this.BtVaciar.TabIndex = 8;
            this.BtVaciar.Text = "Vaciar";
            this.BtVaciar.UseVisualStyleBackColor = true;
            this.BtVaciar.Click += new System.EventHandler(this.BtVaciar_Click);
            // 
            // FormPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.BtVaciar);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.LbTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtAgregar);
            this.Controls.Add(this.TxPila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListPila);
            this.Name = "FormPila";
            this.Text = "Pila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListPila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxPila;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbTop;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtVaciar;
    }
}