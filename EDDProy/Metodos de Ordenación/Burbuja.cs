using System;
using System.Linq;
using System.Windows.Forms;
using EDDemo.Ordenacion;

namespace EDDemo.Forms
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
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

                OrdenacionBurbuja ordenacion = new OrdenacionBurbuja();
                int[] numerosOrdenados = ordenacion.OrdenarPorBurbuja(numeros);

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
