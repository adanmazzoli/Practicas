using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

              Console.Write("Escribe tu nombre: ");
              nombre = Console.ReadLine();

              foreach (var sub in nombre)
              {
                  Console.Write($" {sub}");
              }

              Console.ReadKey();
        }
    }
}
