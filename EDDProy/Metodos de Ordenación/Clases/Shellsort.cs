using System;

namespace EDDemo.Ordenacion
{
    public class OrdenacionShellSort
    {
        public int[] OrdenarPorShellSort(int[] arreglo)
        {
            int n = arreglo.Length;

            for (int intervalo = n / 2; intervalo > 0; intervalo /= 2)
            {
                for (int i = intervalo; i < n; i++)
                {
                    int temp = arreglo[i];
                    int j;

                    for (j = i; j >= intervalo && arreglo[j - intervalo] > temp; j -= intervalo)
                    {
                        arreglo[j] = arreglo[j - intervalo];
                    }

                    arreglo[j] = temp;
                }
            }

            return arreglo;
        }
    }
}
