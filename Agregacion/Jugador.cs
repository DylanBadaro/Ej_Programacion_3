using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    internal class Jugador
    {
        public string Nombre { get; set; }
        public int NumeroCamiseta { get; set; }

        public Jugador(string nombre, int numero)
        {
            Nombre = nombre;
            NumeroCamiseta = numero;
        }
    }
}
