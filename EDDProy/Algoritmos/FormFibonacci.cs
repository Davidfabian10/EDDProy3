using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class FormFibonacci : Form
    {
        private int operationCount;

        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void btnCalcularFibonacci_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(txtFibonacciInput.Text, out num) || num < 0)
            {
                MessageBox.Show("Introduce un número válido mayor o igual a 0.");
                return;
            }

            // Ejecutar el algoritmo de Fibonacci
            operationCount = 0;
            Stopwatch sw = Stopwatch.StartNew();
            long resultado = Fibonacci(num);
            sw.Stop();

            // Mostrar el resultado en las etiquetas
            lblResultadoFibonacci.Text = $"Resultado: {resultado}";
            lblTiempoFibonacci.Text = $"Tiempo de ejecución: {sw.Elapsed.TotalSeconds:F4} segundos";
            lblOperacionesFibonacci.Text = $"Operaciones realizadas: {operationCount}";
        }

        // Método recursivo para calcular Fibonacci
        private long Fibonacci(int n)
        {
            operationCount++;
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
