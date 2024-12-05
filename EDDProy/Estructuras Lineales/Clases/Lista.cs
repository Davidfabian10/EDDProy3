using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void insertarNodo(int valor)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = valor;

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Atras = null;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Atras = ultimo;
                ultimo = nuevo;
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

        public void desplegarListaInversa(TextBox lst)
        {
            Nodo actual = ultimo;
            lst.Text = "";
            while (actual != null)
            {
                lst.Text += actual.Dato + " <- ";
                actual = actual.Atras;
            }
        }

        public bool buscarNodo(int valor)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    return true; 
                }
                actual = actual.Siguiente;
            }

            return false; 
        }

        public bool eliminarNodo(int valor)
        {
            Nodo actual = primero;

            
            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    if (actual == primero) 
                    {
                        primero = primero.Siguiente;
                        if (primero != null) primero.Atras = null;
                    }
                    else if (actual == ultimo) 
                    {
                        ultimo = ultimo.Atras;
                        if (ultimo != null) ultimo.Siguiente = null;
                    }
                    else 
                    {
                        actual.Atras.Siguiente = actual.Siguiente;
                        actual.Siguiente.Atras = actual.Atras;
                    }

                    return true; 
                }

                actual = actual.Siguiente;
            }

            return false;
        }
    }
}
