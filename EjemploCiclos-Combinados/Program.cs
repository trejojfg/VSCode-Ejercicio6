using System;

namespace EjemploCiclos_Combinados
{
    class Program
    {
        static void Main(string[] args)
        {
            // CICLOS COMBINADOS: es ANIDAR ciclos (ciclo dentro de otro ciclo)

            // Ejemplo : cargar edades de jugadores por cada equipo de futbol

            // Opcion 1 - FOR con FOR - cargar edades de 20 jugadores por cada equipo de futbol (hay 10 equipos)
            
            int n, prom, acu = 0; // declarar variables para todas las opciones
            int cont = 0; // declarar solo para el FOR con WHILE
            
            // este FOR carga para cada equipo
            
            for (int y = 0; y < 10; y++)
            {
            // este FOR carga la edad de cada persona y calcula el promedio
                acu = 0;         
                for (int x = 0; x < 20; x++)
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n;
                }
                prom = acu / 20;
                Console.WriteLine("El promedio es: " + prom);
            }

            // Opcion 2 - FOR con WHILE - no se cuantos jugadores hay que cargar sus edades,
            // por cada equipo de futbol (hay 10 equipos)

            // este FOR carga para cada equipo

            for (int x = 0; x < 10; x++)
            {
                
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                acu = 0;
                cont = 0;
                // este WHILE carga la edad de cada persona y calcula el promedio
                while (n != 0){
                    acu += n;
                    cont++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                }
                prom = acu / cont;
                Console.WriteLine("El promedio es: " + prom);
            }

            // Opcion 3 - WHILE con FOR - cargar edades de 20 jugadores por cada equipo de futbol,
            //           pero desconozco el numero de equipos

            // este WHILE carga para cada equipo

            Console.WriteLine("Ingrese 1 para comenzar a procesar ó 0 para terminar");
            n = int.Parse(Console.ReadLine());              
            while (n != 0){

            // este FOR carga las edades de los 20 jugadores que tiene un equipo
                acu = 0;
                for (int x = 0; x < 20; x++)
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n;
                }
                prom = acu / 20
                Console.WriteLine("El promedio es: " + prom);

                Console.WriteLine("Ingrese 1 para continuar ó 0 para terminar");
                n = int.Parse(Console.ReadLine());   
            }

            // Opcion 4 - WHILE con WHILE - cargar edades de jugadores por cada equipo de futbol, pero
            //            no sabemos ni el numero de jugadores ni el numero de equipos

            // este WHILE carga para cada equipo

            Console.WriteLine("Ingrese la edad: ");
            n = int.Parse(Console.ReadLine());              
            while (n > 0){
                acu = 0;
                cont = 0;
                // este WHILE carga la edad de cada persona y calcula el promedio
                while (n != 0){
                    acu += n;
                    cont++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                }
                prom = acu / cont;
                Console.WriteLine("El promedio es: " + prom);

                Console.WriteLine("Ingrese la edad para continuar o un negativo para terminar");
                n = int.Parse(Console.ReadLine());  
            }


            Console.WriteLine("Fin del programa");
        }
    }
}
