using ConceptosPOO;
using System;

//Para no usar el math cada vez que quieras usarlo.
using static System.Math;

//Para no tener que usar Console adelante de WriteLine // ReadLine.
using static System.Console;

namespace ConceptoPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            /*realizarTarea();

            double raiz = Sqrt(9);

            double potencia = Pow(3, 4);

            Console.WriteLine(raiz);

            Console.WriteLine(potencia);
            */

            //Clase anonyma
            var miVariable = new { Nombre = "Lucas", Edad = 22 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);

            var miOtraVariable = new { Nombre = "Ana", Edad = 25 };

            miVariable = miOtraVariable;

        }

        static void realizarTarea()
        {

            Punto origen = new Punto();

            Punto destino = new Punto(128, 80);

            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Número de objetos creados: {Punto.ContadorDeObjetos()}");
       
        }


    }
}