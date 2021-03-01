using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numero = new float[5];
 
           Console.Write("\nTeclee el primer número:    ");
            numero[0] = Convert.ToSingle(Console.ReadLine());
           Console.Write("\nTeclee el segundo número:    ");
            numero[1] = Convert.ToSingle(Console.ReadLine());
           Console.Write("\nTeclee el tercero número:    ");
            numero[2] = Convert.ToSingle(Console.ReadLine());
           Console.Write("\nTeclee el cuarto número:    ");
            numero[3] = Convert.ToSingle(Console.ReadLine());
           Console.Write("\nTeclee el quinto número:    ");
            numero[4] = Convert.ToSingle(Console.ReadLine());
 
          Console.WriteLine("\n\nLos números tecleados alrrevés son:  {4}, {3}, {2}, {1}, {0}", numero[0], numero[1], numero[2], numero[3], numero[4]);
          Console.ReadLine();
        }
    }
}
