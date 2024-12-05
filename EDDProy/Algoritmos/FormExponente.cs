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
    public partial class FormExponente : Form
    {
        private int operationCount;

        public FormExponente()
        {
            InitializeComponent();
        }

        private void btCalcularExponente_Click(object sender, EventArgs e)
        {
            int baseNum, exp;
            if (!int.TryParse(txtBaseExponente.Text, out baseNum) || !int.TryParse(txtExponenteInput.Text, out exp))
            {
                MessageBox.Show("Introduce valores válidos para la base y el exponente.");
                return;
            }

            if (exp < 0)
            {
                MessageBox.Show("El exponente no puede ser negativo.");
                return;
            }

            // Ejecutar el algoritmo de exponente
            operationCount = 0;
            Stopwatch sw = Stopwatch.StartNew();
            long resultado = CalcularExponente(baseNum, exp);
            sw.Stop();

            // Mostrar el resultado en las etiquetas
            lblResultadoExponente.Text = $"{baseNum}^{exp} = {resultado}";
            lblTiempoExponente.Text = $"{sw.Elapsed.TotalSeconds:F4} segundos";
            lblOperacionesExponente.Text = $"{operationCount}";
        }

        // Método recursivo para calcular el exponente
        private long CalcularExponente(int baseNum, int exp)
        {
            operationCount++;
            if (exp == 0)
                return 1;
            return baseNum * CalcularExponente(baseNum, exp - 1);
        }
    }
}
