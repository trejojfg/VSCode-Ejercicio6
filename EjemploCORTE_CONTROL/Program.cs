using System;

namespace EjemploCORTE_CONTROL
{
    class Program
    {
        static void Main(string[] args)
        {
            // CORTE DE CONTROL  (casi siempre es WHILE con WHILE)

            // Es para manejar un lote de datos, AGRUPADOS por sublotes

            // Ejemplo: De cada Equipo, se registran el nombre, edad y sueldo de caja jugardor.
            //          Los equipos estan agrupados por Codigo de Equipo.

            int nombre, edad, codigoEquipo;
            float sueldo;
            int equipoActual;

            Console.WriteLine("Ingrese el nombre");
            nombre = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de Equipo");
            codigoEquipo = int.Parse(Console.ReadLine());

            while (sueldo > 0)  
            {
                equipoActual == codigoEquipo;  // ESTA ASIGNACION ES LA CLAVE DEL CORTE CONTROL
                while (codigoEquipo == equipoActual)   
                {
                    // se procesa todo lo solicitado

                Console.WriteLine("Ingrese el nombre");
                nombre = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la edad");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el sueldo");
                sueldo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el codigo de Equipo");
                codigoEquipo = int.Parse(Console.ReadLine());

                // se muestran los resultado del sublote (si los solicita)

                }
                // se muestran los resultado del sublote (si los solicita)

            }
            // se muestran los resultado del sublote (si los solicita)

            Console.WriteLine("Fin del programa");
        }
    }
}
