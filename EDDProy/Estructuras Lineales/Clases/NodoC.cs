using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    class NodoCircular
    {
        private int dato;
        private NodoCircular siguiente;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public NodoCircular Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
