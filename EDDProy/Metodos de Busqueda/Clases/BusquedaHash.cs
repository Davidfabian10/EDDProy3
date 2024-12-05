using System;
using System.Collections.Generic;

namespace EDDemo.Busqueda
{
    public class BusquedaHash
    {
        private Dictionary<int, string> tablaHash;

        public BusquedaHash()
        {
            tablaHash = new Dictionary<int, string>();
        }

        public void Agregar(int clave, string valor)
        {
            if (!tablaHash.ContainsKey(clave))
            {
                tablaHash.Add(clave, valor);
            }
            else
            {
                throw new ArgumentException("La clave ya existe en la tabla hash.");
            }
        }

        public string Buscar(int clave)
        {
            if (tablaHash.TryGetValue(clave, out string valor))
            {
                return valor;
            }
            else
            {
                return null;
            }
        }

        public Dictionary<int, string> ObtenerElementos()
        {
            return new Dictionary<int, string>(tablaHash);
        }
    }
}
