using System;
using System.Windows.Forms;
using EDDemo.Busqueda;

namespace EDDemo.Forms
{
    public partial class frmBusquedaHash : Form
    {
        private BusquedaHash tablaHash;

        public frmBusquedaHash()
        {
            InitializeComponent();
            tablaHash = new BusquedaHash();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtClave.Text, out int clave))
            {
                MessageBox.Show("Ingrese una clave válida, número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                tablaHash.Agregar(clave, txtValor.Text);
                ActualizarTablaHash();
                txtClave.Clear();
                txtValor.Clear();
                txtClave.Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtClaveBuscar.Text, out int clave))
            {
                MessageBox.Show("Ingrese una clave para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string valor = tablaHash.Buscar(clave);

            if (valor != null)
            {
                lblResultado.Text = $"Clave: {clave}, Valor: {valor}";
            }
            else
            {
                lblResultado.Text = "Clave no encontrada.";
            }
        }

        private void ActualizarTablaHash()
        {
            lstElementos.Items.Clear();
            foreach (var par in tablaHash.ObtenerElementos())
            {
                lstElementos.Items.Add($"Clave: {par.Key}, Valor: {par.Value}");
            }
        }
    }
}