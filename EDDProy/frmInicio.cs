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
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
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
    }
}
