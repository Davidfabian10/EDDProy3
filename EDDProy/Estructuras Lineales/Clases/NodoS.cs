using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    class NodoS
    {
        private int dato;
        private Nodo siguiente;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}