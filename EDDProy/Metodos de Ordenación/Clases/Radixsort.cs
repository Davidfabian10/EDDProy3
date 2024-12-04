using System;
using System.Collections.Generic;

namespace EDDemo.Ordenacion
{
    public class OrdenacionRadixSort
    {
        public int[] OrdenarPorRadixSort(int[] arreglo)
        {
            int max = ObtenerMaximo(arreglo);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                arreglo = ContarPorDígitos(arreglo, exp);
            }

            return arreglo;
        }

        private int ObtenerMaximo(int[] arreglo)
        {
            int max = arreglo[0];
            foreach (int num in arreglo)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        private int[] ContarPorDígitos(int[] arreglo, int exp)
        {
            int n = arreglo.Length;
            int[] salida = new int[n];
            int[] conteo = new int[10];

            for (int i = 0; i < n; i++)
            {
                int indice = (arreglo[i] / exp) % 10;
                conteo[indice]++;
            }

            for (int i = 1; i < 10; i++)
            {
                conteo[i] += conteo[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int indice = (arreglo[i] / exp) % 10;
                salida[conteo[indice] - 1] = arreglo[i];
                conteo[indice]--;
            }

            return salida;
        }
    }
}
