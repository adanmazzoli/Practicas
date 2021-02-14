using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
           Console.Write("ABECEDARIO DESCENDENTE");
           Console.WriteLine();
            for(i = 90; i >= 65 ; i--)
            {
               Console.WriteLine(Convert.ToString((char)i));
            }
            Console.ReadLine();
        }
    }
}
