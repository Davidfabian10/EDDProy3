﻿
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtPodar = new System.Windows.Forms.Button();
            this.BtENSucesor = new System.Windows.Forms.Button();
            this.BtENPredecesor = new System.Windows.Forms.Button();
            this.BtRecorrerNiveles = new System.Windows.Forms.Button();
            this.BtAltura = new System.Windows.Forms.Button();
            this.BtHojas = new System.Windows.Forms.Button();
            this.BtNodos = new System.Windows.Forms.Button();
            this.BtRevisionBinario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(70, 66);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(52, 26);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(70, 98);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(6, 198);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(696, 420);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(319, 120);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 24);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(70, 157);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(62, 24);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(207, 12);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(62, 32);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(11, 69);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(36, 13);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(70, 11);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(62, 34);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(6, 17);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(60, 24);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(177, 126);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(60, 13);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(246, 126);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(177, 98);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(48, 13);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(177, 69);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(55, 13);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(246, 98);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(246, 69);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(70, 126);
            this.BtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(62, 24);
            this.BtBuscar.TabIndex = 15;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtPodar
            // 
            this.BtPodar.Location = new System.Drawing.Point(319, 11);
            this.BtPodar.Margin = new System.Windows.Forms.Padding(2);
            this.BtPodar.Name = "BtPodar";
            this.BtPodar.Size = new System.Drawing.Size(148, 24);
            this.BtPodar.TabIndex = 16;
            this.BtPodar.Text = "Podar Arbol";
            this.BtPodar.UseVisualStyleBackColor = true;
            this.BtPodar.Click += new System.EventHandler(this.BtPodar_Click);
            // 
            // BtENSucesor
            // 
            this.BtENSucesor.Location = new System.Drawing.Point(319, 87);
            this.BtENSucesor.Margin = new System.Windows.Forms.Padding(2);
            this.BtENSucesor.Name = "BtENSucesor";
            this.BtENSucesor.Size = new System.Drawing.Size(148, 24);
            this.BtENSucesor.TabIndex = 17;
            this.BtENSucesor.Text = "Eliminar Nodo Sucesor";
            this.BtENSucesor.UseVisualStyleBackColor = true;
            this.BtENSucesor.Click += new System.EventHandler(this.BtENSucesor_Click);
            // 
            // BtENPredecesor
            // 
            this.BtENPredecesor.Location = new System.Drawing.Point(319, 49);
            this.BtENPredecesor.Margin = new System.Windows.Forms.Padding(2);
            this.BtENPredecesor.Name = "BtENPredecesor";
            this.BtENPredecesor.Size = new System.Drawing.Size(148, 24);
            this.BtENPredecesor.TabIndex = 18;
            this.BtENPredecesor.Text = "Eliminar Nodo Predecesor";
            this.BtENPredecesor.UseVisualStyleBackColor = true;
            this.BtENPredecesor.Click += new System.EventHandler(this.BtENPredecesor_Click);
            // 
            // BtRecorrerNiveles
            // 
            this.BtRecorrerNiveles.Location = new System.Drawing.Point(319, 157);
            this.BtRecorrerNiveles.Margin = new System.Windows.Forms.Padding(2);
            this.BtRecorrerNiveles.Name = "BtRecorrerNiveles";
            this.BtRecorrerNiveles.Size = new System.Drawing.Size(148, 25);
            this.BtRecorrerNiveles.TabIndex = 19;
            this.BtRecorrerNiveles.Text = "Recorrer por Niveles";
            this.BtRecorrerNiveles.UseVisualStyleBackColor = true;
            this.BtRecorrerNiveles.Click += new System.EventHandler(this.BtRecorrerNiveles_Click);
            // 
            // BtAltura
            // 
            this.BtAltura.Location = new System.Drawing.Point(494, 12);
            this.BtAltura.Margin = new System.Windows.Forms.Padding(2);
            this.BtAltura.Name = "BtAltura";
            this.BtAltura.Size = new System.Drawing.Size(148, 24);
            this.BtAltura.TabIndex = 20;
            this.BtAltura.Text = "Altura";
            this.BtAltura.UseVisualStyleBackColor = true;
            this.BtAltura.Click += new System.EventHandler(this.BtAltura_Click);
            // 
            // BtHojas
            // 
            this.BtHojas.Location = new System.Drawing.Point(494, 49);
            this.BtHojas.Margin = new System.Windows.Forms.Padding(2);
            this.BtHojas.Name = "BtHojas";
            this.BtHojas.Size = new System.Drawing.Size(148, 24);
            this.BtHojas.TabIndex = 21;
            this.BtHojas.Text = "Hojas";
            this.BtHojas.UseVisualStyleBackColor = true;
            this.BtHojas.Click += new System.EventHandler(this.BtHojas_Click);
            // 
            // BtNodos
            // 
            this.BtNodos.Location = new System.Drawing.Point(494, 87);
            this.BtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.BtNodos.Name = "BtNodos";
            this.BtNodos.Size = new System.Drawing.Size(148, 24);
            this.BtNodos.TabIndex = 22;
            this.BtNodos.Text = "Nodos";
            this.BtNodos.UseVisualStyleBackColor = true;
            this.BtNodos.Click += new System.EventHandler(this.BtNodos_Click);
            // 
            // BtRevisionBinario
            // 
            this.BtRevisionBinario.Location = new System.Drawing.Point(494, 120);
            this.BtRevisionBinario.Margin = new System.Windows.Forms.Padding(2);
            this.BtRevisionBinario.Name = "BtRevisionBinario";
            this.BtRevisionBinario.Size = new System.Drawing.Size(148, 24);
            this.BtRevisionBinario.TabIndex = 23;
            this.BtRevisionBinario.Text = "Revision de Arbol Binario";
            this.BtRevisionBinario.UseVisualStyleBackColor = true;
            this.BtRevisionBinario.Click += new System.EventHandler(this.BtRevisionBinario_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 24);
            this.button1.TabIndex = 24;
            this.button1.Text = "Revision de AB Lleno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtRevisionBinario);
            this.Controls.Add(this.BtNodos);
            this.Controls.Add(this.BtHojas);
            this.Controls.Add(this.BtAltura);
            this.Controls.Add(this.BtRecorrerNiveles);
            this.Controls.Add(this.BtENPredecesor);
            this.Controls.Add(this.BtENSucesor);
            this.Controls.Add(this.BtPodar);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtPodar;
        private System.Windows.Forms.Button BtENSucesor;
        private System.Windows.Forms.Button BtENPredecesor;
        private System.Windows.Forms.Button BtRecorrerNiveles;
        private System.Windows.Forms.Button BtAltura;
        private System.Windows.Forms.Button BtHojas;
        private System.Windows.Forms.Button BtNodos;
        private System.Windows.Forms.Button BtRevisionBinario;
        private System.Windows.Forms.Button button1;
    }
}