using System;

namespace Ejercicio6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int n, nLista, cont;

            Console.WriteLine("Introduce un numero positivo mayor que 0");
            n = int.Parse(Console.ReadLine());

            nLista = 1;
            while (n > 0){
                cont = 0;
                while (n != 0 && n > 0){
                    cont++;
                    Console.WriteLine("Introduce otro numero positivo o 0 para terminar lista");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La lista numero: "+ nLista + " tiene " + cont + " numeros.");

                Console.WriteLine("Introduce un numero positivo para iniciar nueva lista o negativo para terminar");
                n = int.Parse(Console.ReadLine());

                if (n > 0){
                    nLista++;
                }
            }

            Console.WriteLine("Fin del programa!");
      

        }
    }
}
