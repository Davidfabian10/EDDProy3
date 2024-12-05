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
    public partial class FormListaCircular : Form
    {

        private ListaCircular objLista;

        public FormListaCircular()
        {
            InitializeComponent();
            objLista = new ListaCircular();
        }

        private void BtCrear_Click(object sender, EventArgs e)
        {
            objLista = new ListaCircular();
            MessageBox.Show("Lista circular creada exitosamente");
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {
                objLista.insertarNodo(int.Parse(txtDato.Text));
                txtDato.Text = "";
                txtDato.Focus();
            }
            
            else MessageBox.Show("Ingrese un dato para agregarlo a la lista", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                if (objLista.eliminarNodo(valor))
                {
                    MessageBox.Show("Dato eliminado exitosamente");
                }
                else
                {
                    MessageBox.Show("Dato no encontrado en la lista", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtDato.Text = "";
                txtDato.Focus();
            }

            else MessageBox.Show("Ingrese un dato para eliminarlo de la lista", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                if (objLista.buscarNodo(valor))
                {
                    MessageBox.Show("El dato se encuentra en la lista");
                }
                else
                {
                    MessageBox.Show("El dato no está en la lista", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtDato.Text = "";
                txtDato.Focus();
            }

            else MessageBox.Show("Ingrese un dato para buscarlo en la lista", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtVerLista_Click(object sender, EventArgs e)
        {
            txtLista.Text = "";
            if (BtVerLista.Text == "Ver Lista")
            {
                objLista.desplegarLista(txtLista);
                BtVerLista.Text = "Ver Lista";
            }

            else MessageBox.Show("Lista vacia, ingrese datos para visuaizar", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
