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
    public partial class FormBusquedaBinaria : Form
    {
        private int[] arreglo;
        private int operationCount;

        public FormBusquedaBinaria()
        {
            InitializeComponent();
        }
        private void btnGenerarArreglo_Click(object sender, EventArgs e)
        {
            int tamaño;
            if (!int.TryParse(txtTamañoArreglo.Text, out tamaño) || tamaño <= 0)
            {
                MessageBox.Show("Introduce un tamaño válido para el arreglo.");
                return;
            }

            // Generar un arreglo de números aleatorios y ordenarlo
            arreglo = new int[tamaño];
            Random rand = new Random();
            for (int i = 0; i < tamaño; i++)
            {
                arreglo[i] = rand.Next(1, 101); // Números entre 1 y 100
            }

            Array.Sort(arreglo); // Ordenar el arreglo

            // Mostrar el arreglo en el ListBox
            lstArreglo.Items.Clear();
            foreach (int num in arreglo)
            {
                lstArreglo.Items.Add(num);
            }

            MessageBox.Show("Arreglo generado y ordenado.");
        }

        // Evento del botón para realizar la búsqueda binaria
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valor;
            if (!int.TryParse(txtValorBuscar.Text, out valor))
            {
                MessageBox.Show("Introduce un valor válido para buscar.");
                return;
            }

            if (arreglo == null || arreglo.Length == 0)
            {
                MessageBox.Show("Primero debes generar un arreglo.");
                return;
            }

            // Ejecutar el algoritmo de búsqueda binaria
            operationCount = 0;
            Stopwatch sw = Stopwatch.StartNew();
            int resultado = BusquedaBinaria(arreglo, valor, 0, arreglo.Length - 1);
            sw.Stop();

            // Mostrar el resultado
            if (resultado == -1)
            {
                lblResultadoBusqueda.Text = "El número no se encuentra en el arreglo.";
            }
            else
            {
                lblResultadoBusqueda.Text = $"El número {valor} se encuentra en la posición {resultado}.";
            }

            lblTiempoBusqueda.Text = $"Tiempo de ejecución: {sw.Elapsed.TotalSeconds:F4} segundos";
            lblOperacionesBusqueda.Text = $"Operaciones realizadas: {operationCount}";
        }

        // Método recursivo para realizar la búsqueda binaria
        private int BusquedaBinaria(int[] arr, int target, int low, int high)
        {
            operationCount++;
            if (low > high)
                return -1;

            int mid = (low + high) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] > target)
                return BusquedaBinaria(arr, target, low, mid - 1);
            else
                return BusquedaBinaria(arr, target, mid + 1, high);
        }
    }
}
