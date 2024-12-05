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
    public partial class FormPila : Form
    {
        class Nodo
        {
            public string Dato;
            public Nodo Sig; 
        }

        private Nodo Top = null;

        public FormPila()
        {
            InitializeComponent();
        }

        public void ListarPila()
        {  

            ListPila.Items.Clear();
            LbTop.Text = "";
            Nodo actual = Top;

            if (Top != null)
            {
                while (actual != null)
                {
                    ListPila.Items.Add(actual.Dato);
                    actual = actual.Sig;
                }

                LbTop.Text = Top.Dato;
            }
        } 

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            if (TxPila.Text != "")
            {
                Nodo nuevo = new Nodo();  
                nuevo.Dato = TxPila.Text; 
                nuevo.Sig = null; 

                if (Top == null)
                {
                    Top = nuevo;  
                }
                else
                {
                    Nodo aux = Top;
                    Top = nuevo;
                    Top.Sig = aux;
                }

                TxPila.Text = "";
                TxPila.Focus();
                ListarPila();
            }

            else MessageBox.Show("Ingrese un dato para agregarlo a la pila", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (Top != null)
            {
                Nodo aux = Top; 
                Top = Top.Sig;  
                aux = null; 

                ListarPila();
            }

            else MessageBox.Show("Ingrese un dato para eliminarlo de la pila", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            if (TxPila.Text != "")
            {
                Nodo actual = Top;
                bool encontrado = false;

                while (actual != null)
                {
                    if (actual.Dato == TxPila.Text)
                    {
                        encontrado = true;
                        break;
                    }
                    actual = actual.Sig;
                }

                if (encontrado)
                {
                    MessageBox.Show($"El elemento '{TxPila.Text}' fue encontrado en la pila.", "Elemento encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else MessageBox.Show("El dato no se encuentra en la pila", "¡AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else MessageBox.Show("Ingrese un dato para buscarlo en la pila", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtVaciar_Click(object sender, EventArgs e)
        {
                if (Top != null)
                {
                    Top = null;
                    ListarPila();
                    MessageBox.Show("La pila ha sido vaciada.", "Pila vaciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else MessageBox.Show("La pila ya está vacía.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
