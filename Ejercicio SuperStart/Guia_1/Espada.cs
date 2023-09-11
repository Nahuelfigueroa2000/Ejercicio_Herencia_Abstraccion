using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart.Guia_1
{
    internal class Espada : Arma
    {
        public Espada(int danio_base) : base(danio_base) { }
        public override int Ataque(Personaje personaje)
        {
            return personaje.ataque_base + Danio_base;
        }
    }
}
