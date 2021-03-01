using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
           multiplicar v = new multiplicar();
            Console.WriteLine("Ingrese el numero");
            v.tabla = Console.ReadLine();

            v.num = int.Parse(v.tabla);

            for (v.i = 0; v.i < 13; v.i++)
            {
                Console.WriteLine(v.i + "x" + v.num + " = " + v.i * v.num );
            }

            Console.ReadKey();  
        } 
        
    }

    class multiplicar
    {

        public int num;
        public int i;
        public string tabla;

    }
}
