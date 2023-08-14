using System;

namespace Ejercicio6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            // Se pide determinar e informar:

            // - El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // - Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            
            int n, contImpar, contNumeros, maxGrupoImpar = 0, min, BContMin, contGrupoOrden = 0;
            double porcImpar, maxPorcImpar = 0;
            bool Bmin;
            
            for (int x = 0; x < 5; x++){
                contImpar = 0;
                contNumeros = 0;
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                min = n;
                Bmin = false;
                BContMin = 0;
                while (n != 0){
                    contNumeros++;
                    if (n % 2 != 0){
                        contImpar++;
                    }
                    if (Bmin){
                        min = n;
                        Bmin = true;
                    }else{
                        if (n > min){
                            BContMin++;
                        }
                    }

                    Console.WriteLine("Ingrese otro numero o un 0 para terminar");
                    n = int.Parse(Console.ReadLine());
                } // termina el while

                porcImpar = contImpar / contNumeros;
                if (porcImpar > maxPorcImpar){
                    maxPorcImpar = porcImpar;
                    maxGrupoImpar = (x + 1);
                }
                if (BContMin == 0){
                    contGrupoOrden++;
                }
            } // termina el for

            
            Console.WriteLine("El grupo con mayor porcentaje de impares es el: " + maxGrupoImpar);
            Console.WriteLine("Hay un total de grupos ordenados decrecientemente de: " + contGrupoOrden);


            Console.WriteLine("Fin del programa!");

        }
    }
}
