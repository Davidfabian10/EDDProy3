using System;
using System.Collections;
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
    public partial class FormCola : Form
    {
        class Nodo
        {
            public string Dato;
            public Nodo Sig;  
        }

        private Nodo Primero = null; 
        private Nodo Ultimo = null;

        public FormCola()
        {
            InitializeComponent();
        }

        public void ListarCola()
        {
            ListCola.Items.Clear();
            LbTop.Text = "";
            Nodo actual = Primero;

            if (Primero != null)
            {
                while (actual != null)
                {
                    ListCola.Items.Add(actual.Dato);
                    actual = actual.Sig;
                }

                LbTop.Text = Primero.Dato;
            }
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            if (TxCola.Text != "")
            {
                Nodo nuevo = new Nodo();  
                nuevo.Dato = TxCola.Text;  
                nuevo.Sig = null;

                if (Primero == null)
                {
                    Primero = nuevo;
                    Ultimo = nuevo; 
                }
                else
                {
                    Ultimo.Sig = nuevo;
                    Ultimo = nuevo; 
                }

                TxCola.Text = "";
                TxCola.Focus();
                ListarCola();
            }

            else MessageBox.Show("Ingrese un dato para agregarlo a la cola", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (Primero != null)
            {
                Nodo aux = Primero; 
                Primero = Primero.Sig; 

                if (Primero == null)
                {
                    Ultimo = null;
                }

                aux = null;  

                ListarCola();
            }

            else MessageBox.Show("Ingrese un dato para eliminarlo de la cola", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            string elementoBuscar = TxCola.Text;
            if (elementoBuscar != "")
            {
                Nodo actual = Primero;
                bool encontrado = false;

                while (actual != null)
                {
                    if (actual.Dato == elementoBuscar)
                    {
                        encontrado = true;
                        break;
                    }
                    actual = actual.Sig;
                }

                if (encontrado)
                {
                    MessageBox.Show($"El elemento '{elementoBuscar}' se encuentra en la cola.");
                }
                else
                {
                    MessageBox.Show($"El elemento '{elementoBuscar}' no se encuentra en la cola.");
                }
            }

            else MessageBox.Show("Ingrese un dato para buscarlo en la cola", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TxCola.Focus();
        }

        private void BtVacial_Click(object sender, EventArgs e)
        {
            if (Primero != null)
            {
                Primero = null; 
                Ultimo = null;  
                ListarCola();
                MessageBox.Show("La cola esta vacia", "Cola vaciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else MessageBox.Show("La cola ya se encuentra vacia", "¡AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
