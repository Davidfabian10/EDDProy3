using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class FormFactorial : Form
    {
        private int operationCount;

        public FormFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcularFactorial_Click(object sender, EventArgs e)
        {
            int num;

            if (!int.TryParse(txtFactorialInput.Text, out num))
            {
                MessageBox.Show("Introduce un número válido.");
                return;
            }

            if (num < 0)
            {
                MessageBox.Show("El factorial no está definido para números negativos.");
                return;
            }

            // Ejecutar el algoritmo de factorial
            operationCount = 0;
            Stopwatch sw = Stopwatch.StartNew();
            long resultado = Factorial(num);
            sw.Stop();

            // Mostrar el resultado en las etiquetas
            lblResultadoFactorial.Text = $"{resultado}";
            lblTiempoFactorial.Text = $"{sw.Elapsed.TotalSeconds:F4} segundos";
            lblOperacionesFactorial.Text = $"{operationCount}";
        }

        private long Factorial(int n)
        {
            operationCount++;
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);

        }
    }
}
