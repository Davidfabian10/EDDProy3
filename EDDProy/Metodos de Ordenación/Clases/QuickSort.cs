using System;

namespace EDDemo.Ordenacion
{
    public class OrdenacionQuickSort
    {
        public int[] OrdenarPorQuickSort(int[] arreglo)
        {
            QuickSort(arreglo, 0, arreglo.Length - 1);
            return arreglo;
        }

        private void QuickSort(int[] arreglo, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int indicePivote = Particionar(arreglo, inicio, fin);

                QuickSort(arreglo, inicio, indicePivote - 1);
                QuickSort(arreglo, indicePivote + 1, fin);
            }
        }

        private int Particionar(int[] arreglo, int inicio, int fin)
        {
            int pivote = arreglo[fin];
            int indiceMenor = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (arreglo[j] <= pivote)
                {
                    indiceMenor++;
                    Intercambiar(arreglo, indiceMenor, j);
                }
            }

            Intercambiar(arreglo, indiceMenor + 1, fin);
            return indiceMenor + 1;
        }

        private void Intercambiar(int[] arreglo, int i, int j)
        {
            int temp = arreglo[i];
            arreglo[i] = arreglo[j];
            arreglo[j] = temp;
        }
    }
}
