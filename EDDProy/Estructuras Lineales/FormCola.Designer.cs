namespace EDDemo
{
    partial class FormCola
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
            this.ListCola = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxCola = new System.Windows.Forms.TextBox();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTop = new System.Windows.Forms.Label();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtVacial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListCola
            // 
            this.ListCola.FormattingEnabled = true;
            this.ListCola.Location = new System.Drawing.Point(42, 42);
            this.ListCola.Name = "ListCola";
            this.ListCola.Size = new System.Drawing.Size(168, 303);
            this.ListCola.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa dato:";
            // 
            // TxCola
            // 
            this.TxCola.Location = new System.Drawing.Point(235, 58);
            this.TxCola.Name = "TxCola";
            this.TxCola.Size = new System.Drawing.Size(152, 20);
            this.TxCola.TabIndex = 2;
            // 
            // BtAgregar
            // 
            this.BtAgregar.Location = new System.Drawing.Point(235, 102);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(93, 29);
            this.BtAgregar.TabIndex = 3;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = true;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(357, 102);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(93, 29);
            this.BtEliminar.TabIndex = 4;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOP de cola:";
            // 
            // LbTop
            // 
            this.LbTop.AutoSize = true;
            this.LbTop.Location = new System.Drawing.Point(232, 247);
            this.LbTop.Name = "LbTop";
            this.LbTop.Size = new System.Drawing.Size(0, 13);
            this.LbTop.TabIndex = 6;
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(235, 157);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(93, 29);
            this.BtBuscar.TabIndex = 7;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtVacial
            // 
            this.BtVacial.Location = new System.Drawing.Point(357, 157);
            this.BtVacial.Name = "BtVacial";
            this.BtVacial.Size = new System.Drawing.Size(93, 29);
            this.BtVacial.TabIndex = 8;
            this.BtVacial.Text = "Vaciar";
            this.BtVacial.UseVisualStyleBackColor = true;
            this.BtVacial.Click += new System.EventHandler(this.BtVacial_Click);
            // 
            // FormCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.BtVacial);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.LbTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtAgregar);
            this.Controls.Add(this.TxCola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListCola);
            this.Name = "FormCola";
            this.Text = "FormCola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListCola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxCola;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbTop;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtVacial;
    }
}