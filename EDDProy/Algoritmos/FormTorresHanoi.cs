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
    public partial class FormTorresHanoi : Form
    {
        private int operationCount;

        public FormTorresHanoi()
        {
            InitializeComponent();
        }

        private void btnCalcularTorresHanoi_Click(object sender, EventArgs e)
        {
            int numDiscos;
            if (!int.TryParse(txtNumeroDiscos.Text, out numDiscos) || numDiscos <= 0)
            {
                MessageBox.Show("Introduce un número válido de discos mayor a 0.");
                return;
            }

            // Limpiar el ListBox antes de calcular
            lstResultados.Items.Clear();

            // Ejecutar el algoritmo de Torres de Hanoi
            operationCount = 0;
            Stopwatch sw = Stopwatch.StartNew();
            TorresHanoi(numDiscos, 'A', 'C', 'B');
            sw.Stop();

            // Mostrar el tiempo y las operaciones
            lblTiempoTorresHanoi.Text = $"Tiempo de ejecución: {sw.Elapsed.TotalSeconds:F4} segundos";
            lblOperacionesTorresHanoi.Text = $"Operaciones realizadas: {operationCount}";
        }

        // Método recursivo para resolver Torres de Hanoi
        private void TorresHanoi(int n, char from, char to, char aux)
        {
            operationCount++;
            if (n == 1)
            {
                lstResultados.Items.Add($"Mover disco 1 de {from} a {to}");
                return;
            }

            TorresHanoi(n - 1, from, aux, to);
            lstResultados.Items.Add($"Mover disco {n} de {from} a {to}");
            TorresHanoi(n - 1, aux, to, from);
        }
    }
}
