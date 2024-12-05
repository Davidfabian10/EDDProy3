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
    public partial class FormSumarArreglo : Form
    {
        private int operationCount;

        public FormSumarArreglo()
        {
            InitializeComponent();
        }

        private void btnCalcularSumaArreglo_Click(object sender, EventArgs e)
        {
            int tamaño;
            if (!int.TryParse(txtTamañoArreglo.Text, out tamaño) || tamaño <= 0)
            {
                MessageBox.Show("Introduce un tamaño válido para el arreglo.");
                return;
            }

            // Separar los elementos introducidos por comas
            string[] elementos = txtElementosArreglo.Text.Split(',');

            if (elementos.Length != tamaño)
            {
                MessageBox.Show($"Debes introducir {tamaño} elementos separados por comas.");
                return;
            }

            // Convertir los elementos a un array de enteros
            int[] arreglo;
            try
            {
                arreglo = elementos.Select(int.Parse).ToArray();
            }
            catch
            {
                MessageBox.Show("Introduce solo valores numéricos válidos.");
                return;
            }

            // Ejecutar el algoritmo de suma del arreglo
            operationCount = 0;
            Stopwatch sw = Stopwatch.StartNew();
            int resultado = SumarArreglo(arreglo, arreglo.Length - 1);
            sw.Stop();

            // Mostrar el resultado en las etiquetas
            lblResultadoSuma.Text = $"{resultado}";
            lblTiempoSuma.Text = $"{sw.Elapsed.TotalSeconds:F4} segundos";
            lblOperacionesSuma.Text = $"{operationCount}";
        }

        // Método recursivo para sumar los elementos del arreglo
        private int SumarArreglo(int[] arr, int index)
        {
            operationCount++;
            if (index < 0)
                return 0;
            return arr[index] + SumarArreglo(arr, index - 1);
        }
    }
}
