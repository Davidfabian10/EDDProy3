using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Forms;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPila mPila = new FormPila();
            mPila.MdiParent = this;
            mPila.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void metodosDeOrdenammientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void intercalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void intercalacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIntercalacion mIntercalacion = new frmIntercalacion();
            mIntercalacion.MdiParent = this;
            mIntercalacion.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja mBurbuja = new frmBurbuja();
            mBurbuja.MdiParent = this;
            mBurbuja.Show();
        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuickSort mQuickSort = new frmQuickSort();  
            mQuickSort.MdiParent = this;
            mQuickSort.Show();
        }

        private void shellsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShellSort mShellSort = new frmShellSort();
            mShellSort.MdiParent = this;
            mShellSort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadixSort mRadixSort = new frmRadixSort();
            mRadixSort.MdiParent = this;
            mRadixSort.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void binarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBinaria mBusquedaBinaria = new frmBusquedaBinaria();
            mBusquedaBinaria.MdiParent = this;
            mBusquedaBinaria.Show();
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaHash mBusquedaHash = new frmBusquedaHash();
            mBusquedaHash.MdiParent = this;
            mBusquedaHash.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBusquedaBinaria mBusquedaBinaria = new FormBusquedaBinaria();
            mBusquedaBinaria.MdiParent = this;
            mBusquedaBinaria.Show();
        }

        private void exponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExponente mExponente = new FormExponente();
            mExponente.MdiParent = this;
            mExponente.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactorial mFactorial = new FormFactorial();
            mFactorial.MdiParent = this;
            mFactorial.Show();
        }

        private void sumarArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSumarArreglo mSumarArreglo = new FormSumarArreglo();
            mSumarArreglo.MdiParent = this;
            mSumarArreglo.Show();
        }

        private void torresDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTorresHanoi mTorresHanoi = new FormTorresHanoi();
            mTorresHanoi.MdiParent = this;
            mTorresHanoi.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFibonacci mFibonacci = new FormFibonacci();
            mFibonacci.MdiParent = this;
            mFibonacci.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCola mCola = new FormCola();
            mCola.MdiParent = this;
            mCola.Show();
        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListasSimples mListasSimples = new FormListasSimples();
            mListasSimples.MdiParent = this;
            mListasSimples.Show();
        }

        private void doblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListasDobles mListasDobles = new FormListasDobles();
            mListasDobles.MdiParent = this;
            mListasDobles.Show();
        }

        private void circularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaCircular mListaCircular = new FormListaCircular();
            mListaCircular.MdiParent = this;
            mListaCircular.Show();
        }
    }
}
