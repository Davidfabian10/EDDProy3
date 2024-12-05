
namespace EDDemo
{
    partial class frmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosDeOrdenammientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burbujaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intercalacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mezclaDirectaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mezclaNaturalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosDeBusquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exponenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumarArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torresDeHanoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem,
            this.metodosDeOrdenammientoToolStripMenuItem,
            this.metodosDeBusquedaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaBinariaToolStripMenuItem,
            this.exponenteToolStripMenuItem,
            this.factorialToolStripMenuItem,
            this.sumarArregloToolStripMenuItem,
            this.torresDeHanoiToolStripMenuItem,
            this.fibonacciToolStripMenuItem});
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.algoritmosToolStripMenuItem.Text = "Algoritmos";
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplesToolStripMenuItem,
            this.doblesToolStripMenuItem,
            this.circularesToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no lineales";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // metodosDeOrdenammientoToolStripMenuItem
            // 
            this.metodosDeOrdenammientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internosToolStripMenuItem,
            this.externosToolStripMenuItem});
            this.metodosDeOrdenammientoToolStripMenuItem.Name = "metodosDeOrdenammientoToolStripMenuItem";
            this.metodosDeOrdenammientoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.metodosDeOrdenammientoToolStripMenuItem.Text = "Metodos de Ordenación";
            this.metodosDeOrdenammientoToolStripMenuItem.Click += new System.EventHandler(this.metodosDeOrdenammientoToolStripMenuItem_Click);
            // 
            // internosToolStripMenuItem
            // 
            this.internosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.burbujaToolStripMenuItem,
            this.quicksortToolStripMenuItem,
            this.shellsortToolStripMenuItem,
            this.radixToolStripMenuItem});
            this.internosToolStripMenuItem.Name = "internosToolStripMenuItem";
            this.internosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.internosToolStripMenuItem.Text = "Internos";
            // 
            // burbujaToolStripMenuItem
            // 
            this.burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            this.burbujaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.burbujaToolStripMenuItem.Text = "Burbuja";
            this.burbujaToolStripMenuItem.Click += new System.EventHandler(this.burbujaToolStripMenuItem_Click);
            // 
            // quicksortToolStripMenuItem
            // 
            this.quicksortToolStripMenuItem.Name = "quicksortToolStripMenuItem";
            this.quicksortToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.quicksortToolStripMenuItem.Text = "Quicksort";
            this.quicksortToolStripMenuItem.Click += new System.EventHandler(this.quicksortToolStripMenuItem_Click);
            // 
            // shellsortToolStripMenuItem
            // 
            this.shellsortToolStripMenuItem.Name = "shellsortToolStripMenuItem";
            this.shellsortToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.shellsortToolStripMenuItem.Text = "Shellsort";
            this.shellsortToolStripMenuItem.Click += new System.EventHandler(this.shellsortToolStripMenuItem_Click);
            // 
            // radixToolStripMenuItem
            // 
            this.radixToolStripMenuItem.Name = "radixToolStripMenuItem";
            this.radixToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.radixToolStripMenuItem.Text = "Radix";
            this.radixToolStripMenuItem.Click += new System.EventHandler(this.radixToolStripMenuItem_Click);
            // 
            // externosToolStripMenuItem
            // 
            this.externosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intercalacionToolStripMenuItem1,
            this.mezclaDirectaToolStripMenuItem,
            this.mezclaNaturalToolStripMenuItem});
            this.externosToolStripMenuItem.Name = "externosToolStripMenuItem";
            this.externosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.externosToolStripMenuItem.Text = "Externos";
            // 
            // intercalacionToolStripMenuItem1
            // 
            this.intercalacionToolStripMenuItem1.Name = "intercalacionToolStripMenuItem1";
            this.intercalacionToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.intercalacionToolStripMenuItem1.Text = "Intercalacion";
            this.intercalacionToolStripMenuItem1.Click += new System.EventHandler(this.intercalacionToolStripMenuItem1_Click);
            // 
            // mezclaDirectaToolStripMenuItem
            // 
            this.mezclaDirectaToolStripMenuItem.Name = "mezclaDirectaToolStripMenuItem";
            this.mezclaDirectaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.mezclaDirectaToolStripMenuItem.Text = "Mezcla Directa";
            // 
            // mezclaNaturalToolStripMenuItem
            // 
            this.mezclaNaturalToolStripMenuItem.Name = "mezclaNaturalToolStripMenuItem";
            this.mezclaNaturalToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.mezclaNaturalToolStripMenuItem.Text = "Mezcla Natural";
            // 
            // metodosDeBusquedaToolStripMenuItem
            // 
            this.metodosDeBusquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarioToolStripMenuItem,
            this.hashToolStripMenuItem});
            this.metodosDeBusquedaToolStripMenuItem.Name = "metodosDeBusquedaToolStripMenuItem";
            this.metodosDeBusquedaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.metodosDeBusquedaToolStripMenuItem.Text = "Metodos de Busqueda";
            // 
            // binarioToolStripMenuItem
            // 
            this.binarioToolStripMenuItem.Name = "binarioToolStripMenuItem";
            this.binarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.binarioToolStripMenuItem.Text = "Binario";
            this.binarioToolStripMenuItem.Click += new System.EventHandler(this.binarioToolStripMenuItem_Click);
            // 
            // hashToolStripMenuItem
            // 
            this.hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            this.hashToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hashToolStripMenuItem.Text = "Hash";
            this.hashToolStripMenuItem.Click += new System.EventHandler(this.hashToolStripMenuItem_Click);
            // 
            // busquedaBinariaToolStripMenuItem
            // 
            this.busquedaBinariaToolStripMenuItem.Name = "busquedaBinariaToolStripMenuItem";
            this.busquedaBinariaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.busquedaBinariaToolStripMenuItem.Text = "Busqueda Binaria";
            this.busquedaBinariaToolStripMenuItem.Click += new System.EventHandler(this.busquedaBinariaToolStripMenuItem_Click);
            // 
            // exponenteToolStripMenuItem
            // 
            this.exponenteToolStripMenuItem.Name = "exponenteToolStripMenuItem";
            this.exponenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exponenteToolStripMenuItem.Text = "Exponente";
            this.exponenteToolStripMenuItem.Click += new System.EventHandler(this.exponenteToolStripMenuItem_Click);
            // 
            // factorialToolStripMenuItem
            // 
            this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            this.factorialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.factorialToolStripMenuItem.Text = "Factorial";
            this.factorialToolStripMenuItem.Click += new System.EventHandler(this.factorialToolStripMenuItem_Click);
            // 
            // sumarArregloToolStripMenuItem
            // 
            this.sumarArregloToolStripMenuItem.Name = "sumarArregloToolStripMenuItem";
            this.sumarArregloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumarArregloToolStripMenuItem.Text = "Sumar Arreglo";
            this.sumarArregloToolStripMenuItem.Click += new System.EventHandler(this.sumarArregloToolStripMenuItem_Click);
            // 
            // torresDeHanoiToolStripMenuItem
            // 
            this.torresDeHanoiToolStripMenuItem.Name = "torresDeHanoiToolStripMenuItem";
            this.torresDeHanoiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.torresDeHanoiToolStripMenuItem.Text = "Torres de Hanoi";
            this.torresDeHanoiToolStripMenuItem.Click += new System.EventHandler(this.torresDeHanoiToolStripMenuItem_Click);
            // 
            // fibonacciToolStripMenuItem
            // 
            this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fibonacciToolStripMenuItem.Text = "Fibonacci";
            this.fibonacciToolStripMenuItem.Click += new System.EventHandler(this.fibonacciToolStripMenuItem_Click);
            // 
            // simplesToolStripMenuItem
            // 
            this.simplesToolStripMenuItem.Name = "simplesToolStripMenuItem";
            this.simplesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simplesToolStripMenuItem.Text = "Simples";
            this.simplesToolStripMenuItem.Click += new System.EventHandler(this.simplesToolStripMenuItem_Click);
            // 
            // doblesToolStripMenuItem
            // 
            this.doblesToolStripMenuItem.Name = "doblesToolStripMenuItem";
            this.doblesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doblesToolStripMenuItem.Text = "Dobles";
            this.doblesToolStripMenuItem.Click += new System.EventHandler(this.doblesToolStripMenuItem_Click);
            // 
            // circularesToolStripMenuItem
            // 
            this.circularesToolStripMenuItem.Name = "circularesToolStripMenuItem";
            this.circularesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circularesToolStripMenuItem.Text = "Circulares";
            this.circularesToolStripMenuItem.Click += new System.EventHandler(this.circularesToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 389);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodosDeOrdenammientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burbujaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intercalacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mezclaDirectaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mezclaNaturalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodosDeBusquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaBinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exponenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumarArregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torresDeHanoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularesToolStripMenuItem;
    }
}

