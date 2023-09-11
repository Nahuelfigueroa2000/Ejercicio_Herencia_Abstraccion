using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart.Guia_1
{
    internal abstract class Arma
    {
        public int Danio_base;

        public Arma(int danio_base)
        {
            Danio_base = danio_base;
        }

        public abstract int Ataque(Personaje personaje);
    }
}
