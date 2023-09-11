using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart.Guia_1
{
    internal class Personaje 
    {
        public int vida, ataque_base, defensa_base;
        public string nombre;
        public Arma equipar;
        public Personaje(int vida, int ataque_base, int defensa_base, string nombre) { }

        public void equipar_Arma (Arma arma)
        {
            equipar = arma;
        }

        // aca esta la parte de primero romper con la defensa
        public int atacar(Personaje objetivo)
        {
            int danio = equipar.Ataque(this);
            int danioEfectivo = Math.Max(0, danio - objetivo.defensa_base);
            int vidaAPerder = danioEfectivo;

            objetivo.vida -= vidaAPerder;

            return vidaAPerder;
        }
    }
}
