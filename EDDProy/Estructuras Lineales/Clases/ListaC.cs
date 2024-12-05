using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    class ListaCircular
    {
        private NodoCircular primero;

        public ListaCircular()
        {
            primero = null;
        }

        public void insertarNodo(int valor)
        {
            NodoCircular nuevo = new NodoCircular();
            nuevo.Dato = valor;

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = primero; // Apunta a sí mismo
            }
            else
            {
                NodoCircular actual = primero;
                while (actual.Siguiente != primero)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
                nuevo.Siguiente = primero; // Enlaza el nuevo nodo al inicio
            }
        }

        public void desplegarLista(TextBox lst)
        {
            if (primero == null)
            {
                lst.Text = "Lista vacía";
                return;
            }

            NodoCircular actual = primero;
            do
            {
                lst.Text += actual.Dato + " -> ";
                actual = actual.Siguiente;
            } while (actual != primero);
        }

        public bool buscarNodo(int valor)
        {
            if (primero == null)
            {
                return false;
            }

            NodoCircular actual = primero;

            do
            {
                if (actual.Dato == valor)
                {
                    return true; // Nodo encontrado
                }
                actual = actual.Siguiente;
            } while (actual != primero);

            return false; // Nodo no encontrado
        }

        public bool eliminarNodo(int valor)
        {
            if (primero == null) return false;

            NodoCircular actual = primero;
            NodoCircular anterior = null;

            do
            {
                if (actual.Dato == valor)
                {
                    if (actual == primero) // Eliminar el primer nodo
                    {
                        if (primero.Siguiente == primero) // Solo hay un nodo
                        {
                            primero = null;
                        }
                        else
                        {
                            anterior = primero;
                            while (anterior.Siguiente != primero)
                            {
                                anterior = anterior.Siguiente;
                            }
                            primero = primero.Siguiente;
                            anterior.Siguiente = primero;
                        }
                    }
                    else // Eliminar un nodo intermedio o final
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    return true; // Nodo eliminado
                }

                anterior = actual;
                actual = actual.Siguiente;

            } while (actual != primero);

            return false; // Nodo no encontrado
        }
    }
}
