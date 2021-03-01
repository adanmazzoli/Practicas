using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
              int mayor = 0;
              int[] enteros = new int[10];

	          Console.Write("\n Escriba diez numeros enteros:\n");
	           for (i = 0; i < 10; i++)
	            {
		          string tempVar = Console.ReadLine();
		           if (tempVar != null)
		            {
			          enteros[i] = int.Parse(tempVar);
		            }
	            }
		        for (i = 0; i < 10; i++)
		        {
				  mayor = mayor > enteros[i]? mayor: enteros[i];
		        }
	          Console.Write("\n El mayor de los numeros es: {0:D}", mayor);
	          Console.Read();
        }
    }
}
