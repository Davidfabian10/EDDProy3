using EDDemo.Busqueda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Forms
{
    public partial class frmBusquedaBinaria : Form
    {
        private List<int> numeros;

        public frmBusquedaBinaria()
        {
            InitializeComponent();
            numeros = new List<int>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtElemento.Text, out int elemento))
            {
                MessageBox.Show("Ingrese un número para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numeros.Count == 0)
            {
                MessageBox.Show("Ingrese un arreglo de números para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            numeros.Sort();

            lstOrdenados.Items.Clear();
            foreach (var num in numeros)
            {
                lstOrdenados.Items.Add(num);
            }

            BusquedaBinaria busqueda = new BusquedaBinaria();
            int posicion = busqueda.Buscar(numeros.ToArray(), elemento);

            if (posicion != -1)
            {
                lblResultado.Text = $"Elemento encontrado en la posición: {posicion}";
            }
            else
            {
                lblResultado.Text = "Elemento no encontrado";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Ingrese un arreglo para agregarlo, separado por comas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNumero.Text.Contains(","))
            {
                try
                {
                    var nuevosNumeros = txtNumero.Text
                        .Split(',')
                        .Select(n => int.Parse(n.Trim()))
                        .ToList();

                    numeros.AddRange(nuevosNumeros);
                    foreach (var num in nuevosNumeros)
                    {
                        lstArreglo.Items.Add(num);
                    }

                    txtNumero.Clear();
                    txtNumero.Focus();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingresar el arreglo de números válidos separados por comas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}