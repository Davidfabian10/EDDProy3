using System;

namespace EDDemo.Ordenacion
{
    public class OrdenacionIntercalacion
    {
        public int[] OrdenarPorIntercalacion(int[] arreglo)
        {
            if (arreglo.Length <= 1)
            {
                return arreglo;
            }

            int mitad = arreglo.Length / 2;
            int[] izquierda = new int[mitad];
            int[] derecha = new int[arreglo.Length - mitad];

            Array.Copy(arreglo, 0, izquierda, 0, mitad);
            Array.Copy(arreglo, mitad, derecha, 0, arreglo.Length - mitad);

            izquierda = OrdenarPorIntercalacion(izquierda);
            derecha = OrdenarPorIntercalacion(derecha);

            return Mezclar(izquierda, derecha);
        }

        private int[] Mezclar(int[] izquierda, int[] derecha)
        {
            int[] resultado = new int[izquierda.Length + derecha.Length];
            int i = 0, j = 0, k = 0;

            while (i < izquierda.Length && j < derecha.Length)
            {
                if (izquierda[i] <= derecha[j])
                {
                    resultado[k++] = izquierda[i++];
                }
                else
                {
                    resultado[k++] = derecha[j++];
                }
            }

            while (i < izquierda.Length)
            {
                resultado[k++] = izquierda[i++];
            }

            while (j < derecha.Length)
            {
                resultado[k++] = derecha[j++];
            }

            return resultado;
        }
    }
}
