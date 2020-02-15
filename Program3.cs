using System;

namespace adivina_numero_random
{
    class Program
    {
        static void Main(string[] args)
        {
            bool final = true;
            int a = 0,numero1;
            Random rnd = new Random();

            int numero = rnd.Next(1, 100);
            
            while (final)
            {
                Console.WriteLine("Adivina el numero random en 10 intentos \n");
                
                Console.WriteLine("Primer intento de adivinar");
                int adv;
                while (a <= 10)
                {

                     adv = Convert.ToInt32(Console.ReadLine());

                    if (adv < numero)
                    {
                        
                        Console.Clear();
                        Console.WriteLine("El numero que buscar es mayor que {0} \nNuevo intento", adv);
                    
                        a++;
                    }
                    else if (adv > numero)
                    {
                        
                        Console.Clear();
                        Console.WriteLine("El numero que buscas es menor que {0} \nNumero intento",adv);
                   
                        a++;
                    }
                    else
                    {
                        Console.WriteLine("GANASTE!!!");
                        Console.WriteLine("Volver a jugar? S/N");
                        String v1 = Console.ReadLine();
                        if (v1.Equals("n"))
                        {
                            Console.WriteLine("Hasta luego!!");
                            Console.ReadKey();
                            final = false;
                        }
                        else
                        {
                            a = 0;
                            Console.Clear();
                            Console.WriteLine("Primer intento para adivinar");
                            continue;
                        }

                        Console.Clear();

                    }
                }
                Console.Clear();
                
                Console.WriteLine("Perdiste!! el numero que buscabas era el {0}\n", numero);
                Console.WriteLine("Volver a jugar? S/N");
                String v = Console.ReadLine();
                if (v.Equals("n"))
                {
                    Console.WriteLine("Hasta luego!!");
                    Console.ReadKey();
                    final = false;
                }
                a = 0;
                Console.Clear();
                
            }
            Console.ReadKey();
        }
    }
}
