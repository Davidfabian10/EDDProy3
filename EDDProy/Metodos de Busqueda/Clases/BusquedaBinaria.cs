using System;

namespace EDDemo.Busqueda
{
    public class BusquedaBinaria
    {
        public int Buscar(int[] arreglo, int elemento)
        {
            int inicio = 0;
            int fin = arreglo.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (arreglo[medio] == elemento)
                {
                    return medio;
                }
                else if (arreglo[medio] < elemento)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return -1; 
        }
    }
}
