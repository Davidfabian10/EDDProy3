using System;
using System.Linq;
using System.Windows.Forms;
using EDDemo.Ordenacion;

namespace EDDemo.Forms
{
    public partial class frmIntercalacion : Form
    {
        public frmIntercalacion()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeros.Text))
            {
                MessageBox.Show("Ingrese una lista de números separados por comas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int[] numeros = txtNumeros.Text
                    .Split(',')
                    .Select(n => int.Parse(n.Trim()))
                    .ToArray();

                OrdenacionIntercalacion ordenacion = new OrdenacionIntercalacion();
                int[] numerosOrdenados = ordenacion.OrdenarPorIntercalacion(numeros);

                lstResultado.Items.Clear();
                foreach (int num in numerosOrdenados)
                {
                    lstResultado.Items.Add(num);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números separados por comas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
