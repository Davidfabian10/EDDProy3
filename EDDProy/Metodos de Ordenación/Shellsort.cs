using System;
using System.Linq;
using System.Windows.Forms;
using EDDemo.Ordenacion;

namespace EDDemo.Forms
{
    public partial class frmShellSort : Form
    {
        public frmShellSort()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeros.Text))
            {
                MessageBox.Show("Por favor, ingresa una lista de números separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int[] numeros = txtNumeros.Text
                    .Split(',')
                    .Select(n => int.Parse(n.Trim()))
                    .ToArray();

                OrdenacionShellSort shellSort = new OrdenacionShellSort();
                int[] numerosOrdenados = shellSort.OrdenarPorShellSort(numeros);

                lstResultado.Items.Clear();
                foreach (int num in numerosOrdenados)
                {
                    lstResultado.Items.Add(num);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrate de ingresar solo números separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
