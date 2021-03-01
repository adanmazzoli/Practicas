using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] num = new double [4]; 
            double sum = 0; 
            double media; 
            
            for ( int x = 0; x < 4; x++) 
            { 
                Console.Write( "Ingrese un numero {0}: " , x + 1); 
                num[x] = Convert.ToDouble(Console.ReadLine()); 
                sum += num[x]; 
            } 
            media = sum / 4; 
            Console.Write( "Los numeros ingresados son: " ); 
                
              for ( int y = 0; y < 4; y++)  
              { 
                  Console.Write( " ({0}) " , num[y]); 
              } 
                 
            Console.Write( "Y la media aritmetica es: {0}" , media);
        }
    }
}
