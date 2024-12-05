using System;
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
    public partial class FormListasSimples : Form
    {
        public FormListasSimples()
        {
            InitializeComponent();
        }

        Lista objLista;

        private void btnCrear_Click(object sender, EventArgs e)
        {
            objLista = new Lista();
            MessageBox.Show("Lista creada exitosamente");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {
                objLista.insertarNodo(int.Parse(txtDato.Text));
                txtDato.Text = "";
                txtDato.Focus();
            }

            else MessageBox.Show("Ingrese un dato para agregarlo a la pila", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                objLista.eliminarNodo(valor);
                txtDato.Text = "";
                txtDato.Focus();
                MessageBox.Show("Dato eliminado exitosamente");
            }

            else MessageBox.Show("Ingrese un dato para eliminarlo a la pila", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                objLista.buscarNodo(valor);
                txtDato.Text = "";
                txtDato.Focus();
                MessageBox.Show("El dato se encuentra en la lista");
            }

            else MessageBox.Show("Ingrese un dato para buscarlo en la pila", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            txtLista.Text = "";
            if (btnVerLista.Text == "Ver Lista")
            {
                objLista.desplegarLista(txtLista);
                btnVerLista.Text = "Ver Lista";
            }

            else MessageBox.Show("Lista vacia, ingrese datos para visuaizar", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
