using System;

namespace Ejercicio6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar
            // por pantalla cuántos de esos números son primos.

            int n, cont = 0, totalPrimo = 0;

            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine("Introduce un numero");
                n = int.Parse(Console.ReadLine());
                cont = 0;

                for (int x = 1; x <= n; x++){
                    if (n % x == 0){
                        cont++;
                    }
                }
                if (cont == 2){
                    totalPrimo++;
                }
            }
            Console.WriteLine("Ingresaste un total de " + totalPrimo + " numeros Primos.");


            Console.WriteLine("Fin del programa!");
        }
    }
}
