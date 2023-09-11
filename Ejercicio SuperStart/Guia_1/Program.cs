using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SuperStart.Guia_1
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador(100, 20, 10, "jugador");
            Enemigo enemigo1 = new Enemigo(75, 15, 5, "enemigo 1");
            Enemigo enemigo2 = new Enemigo(65, 10, 5, "enemigo 2");

            jugador1.equipar_Arma(new Espada(15));
            enemigo1.equipar_Arma(new Hacha(10));
            enemigo2.equipar_Arma(new Martillo(5));

            while (jugador1.vida > 0 && (enemigo1.vida > 0 || enemigo2.vida > 0))
            {
                Personaje atacante = SeleccionarAtacante(jugador1, enemigo1, enemigo2);
                Personaje objetivo = SeleccionarObjetivo(jugador1, enemigo1, enemigo2);

                int danio = atacante.atacar(objetivo);

                Console.WriteLine($"{atacante.nombre} ataca a {objetivo.nombre} y hace {danio} puntos de daño."); //string modificado 

                if (objetivo.vida <= 0)
                {
                    Console.WriteLine($"{objetivo.nombre} ha muerto.");
                }
            }

            if (jugador1.vida <= 0)
            {
                Console.WriteLine("El jugador ha muerto. Juego terminado.");
            }
            else
            {
                Console.WriteLine("El jugador ha ganado. Juego terminado.");
            }

            Console.ReadKey();
        }
        private static Personaje SeleccionarObjetivo(params Personaje[] personajes) //params: Una lista separada por comas de argumentos del tipo de los elementos de la matriz.
        {
            Personaje objetivo;
            do
            {
                objetivo = personajes[random.Next(personajes.Length)];
            } while (objetivo.vida <= 0);
            return objetivo;
        }
        private static Personaje SeleccionarAtacante(params Personaje[] personajes)
        {
            return personajes[random.Next(personajes.Length)];
        }
    }
}
