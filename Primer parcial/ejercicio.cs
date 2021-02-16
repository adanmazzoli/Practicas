using System;

namespace Primer_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
           int limiteRetiro = 20000, limiteTransaccion = 10000;
           int B1000, B500, B200, B100;

             Console.Write("Bienvenido al Cajero FDP Inversments. ");
             Console.WriteLine("Seleccione Entidad");
             Console.WriteLine("1- FDP Inversments \n" + 
                "2- Banco Banesco \n" + 
                "3- Banco Santa Cruz \n" + 
                "4- Salir");
              int banco = Convert.ToInt32(Console.ReadLine()); 
              switch (banco)
              {
                  case 1:
                   Console.WriteLine("Bienvenido al Banco FDP Inversments \n" + 
                    "¿Qué va a realizar? \n" + 
                    "1- Retiro \n" + 
                    "2- Deposito \n" + 
                    "3- Salir");
                     
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion == 1)
                    {
                        Console.WriteLine("Cantidad a retirar:  \n " +  $" El limite a retirar es de {limiteRetiro}"); 
                          int cantidadRetirar = Convert.ToInt32(Console.ReadLine());
                          if (cantidadRetirar <= limiteRetiro)
                          {
                              Console.WriteLine($"Cantidad a retirar es de: {cantidadRetirar}, ");
                              Console.WriteLine("Como desea el Dinero \n" + 
                              "1- Billetes de 1,000 \n" + 
                              "2- Billetes de 500 \n" + 
                              "3- Billetes de 200 \n" + 
                              "4- Billetes de 100");
                              
                              int Billetes = Convert.ToInt32(Console.ReadLine());
                               if (Billetes == 1)
                               {
                                  if( (cantidadRetirar >= 1000) )
		                        {
                               B1000 = ((int) cantidadRetirar / 1000);
				                       cantidadRetirar = cantidadRetirar - (B1000 * 1000);
                               Console.WriteLine($"Billetes de 1000: {B1000}");
                               
                               	if( (cantidadRetirar >= 500) )
		                           {
                                  B500 = ((int) cantidadRetirar / 500);
				                          cantidadRetirar = cantidadRetirar - (B500 * 500);
                                  Console.WriteLine($"Billetes de 500: {B500}");
                                  
                                  	if( (cantidadRetirar >= 200) )
		                                 {
                                        B200 = ((int) cantidadRetirar / 200);
				                                cantidadRetirar = cantidadRetirar - (B200 * 200);
                                        Console.WriteLine($"Billetes de 200: {B200}");
                                         
                                          if( (cantidadRetirar >= 200) )
		                                      {
                                             B200 = ((int) cantidadRetirar / 200);
				                                     cantidadRetirar = cantidadRetirar - (B200 * 200);
                                             Console.WriteLine($"Billetes de 200: {B200}");
                               
                                              if( (cantidadRetirar >= 100) )
		                                           {
                                                  B100 = ((int) cantidadRetirar / 100);
				                                          cantidadRetirar = cantidadRetirar - (B100 * 100);
                                                  Console.WriteLine($"Billetes de 100: {B100}");
                              
			                                          }
			                                    }
			                                }
			                          }
			                      }
                               }   

                               else
                               {
                                   Console.WriteLine("Digite una Opcion Valida");
                                   break;
                               }
                       
                          }

                           else if (cantidadRetirar > limiteRetiro)
                          {
                              Console.WriteLine("Ha superado el limite de retiro, por favor ingresar monto valido");
                              break;
                          } 
                    } 

                    else if (opcion == 2)
                    {
                        Console.WriteLine("Ingrese cantidad a Depositar.\n" + $" El limite a transferir es de {limiteTransaccion}"); // Informe de Limite a Retirar.
                         int cantidadTransferir = Convert.ToInt32(Console.ReadLine());
                         if (cantidadTransferir <= limiteTransaccion)
                         {
                           Console.WriteLine("Transacion satisfactoria");
                           Console.WriteLine($"Su Nuevo Balance es de: {cantidadTransferir}");
                           break;
                         }
                         else
                         {
                            Console.WriteLine("Ha excedido limite de Transacion Diaria");
                            Console.WriteLine();
                            break;
                         }
                        
                    }

                    else if (opcion == 3)
                    {
                        Console.WriteLine("Gracias por utilizar el Cajero FDP Inversments");
                        break;
                    }

                    else
                    {
                       Console.WriteLine("Digite una Opción valida");
                       break; 
                    }
                  break;

                  case 2:
                  Console.WriteLine("Sistema no Disponible");
                  break;

                  case 3:
                  Console.WriteLine("Sistema no Disponible");
                  break;

                  case 4:
                  Console.WriteLine("Saliendo de la Aplicacion");
                  break;
                  
                  default:
                  Console.WriteLine("Digite una Opción valida");
                  break;
              }
        
        }
    }
}
