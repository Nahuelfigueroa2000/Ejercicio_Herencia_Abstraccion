using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart.Guia_1
{
    internal class Enemigo : Personaje
    {
        public Enemigo(int vida, int ataque_base, int defensa_base, string nombre) : base(vida, ataque_base, defensa_base, nombre)
        {
            this.vida = vida;
            this.ataque_base = ataque_base;
            this.defensa_base = defensa_base;
            this.nombre = nombre;
        }
    }
}
