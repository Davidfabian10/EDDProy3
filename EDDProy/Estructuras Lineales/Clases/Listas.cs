using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    class ListaS
    {
        private Nodo primero;

        public ListaS()
        {
            primero = null;
        }

        public void insertarNodo(int valor)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = valor;

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
            }
            else
            {
                Nodo actual = primero;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
                nuevo.Siguiente = null;
            }
        }

        public void desplegarLista(TextBox lst)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                lst.Text += actual.Dato + " -> ";
                actual = actual.Siguiente;
            }
        }

        public void eliminarNodo(int valor)
        {
            if (primero == null) return;

            if (primero.Dato == valor)
            {
                primero = primero.Siguiente;
                return;
            }

            Nodo actual = primero;
            while (actual.Siguiente != null && actual.Siguiente.Dato != valor)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
        }

        public bool buscarNodo(int valor)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    return true; // Nodo encontrado
                }
                actual = actual.Siguiente;
            }
            return false; // Nodo no encontrado
        }
    }
}
