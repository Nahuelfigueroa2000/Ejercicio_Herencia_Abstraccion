using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart.Guia_1
{
    internal class Hacha : Arma
    {
        public Hacha(int danio_base) : base(danio_base) { }
        public override int Ataque(Personaje personaje)
        {
            return (int)(personaje.ataque_base * 1.5 + Danio_base);
        }
    }
}