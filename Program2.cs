using System;

namespace lista_contactos
{
    class Program
    {
        static void Main(string[] args)
        {
            

            String[] nombres = new string[4];
            String[] telefonos = new string[4];
            String[] blanco = new string[4];
            bool final = true;
            while (final)
            {
                Console.WriteLine("Agenda de contactos \n");
                Console.WriteLine(" 1-Agregar contacto\n 2-listar\n 3-editar\n 4-Borrar\n 5-Salir");
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        int i = 0;
                        foreach(var nom in nombres)
                        {
                            
                            if (nombres[i] == null)
                            {

                                Console.WriteLine("Nombre del contacto");
                                nombres[i] = Console.ReadLine();
                                Console.WriteLine("Telefono");
                                telefonos[i] = Console.ReadLine();
                                
                                Console.WriteLine("Contacto agregado con exito!");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            i++;

                            if (i == 4)
                            {
                                Console.WriteLine("La lista esta llena");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        break;
                    case 2:
                        Console.WriteLine("---------------------------------\n Lista de todos los contactos");
                        i = 1;
                        foreach(var nom in nombres)
                        {
                            if (nom != null)
                            {
                                Console.WriteLine(i + "-" + nombres[i - 1] + "//" + telefonos[i - 1]);
                                i++;
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("---------------------------------\n Lista de todos los contactos");
                        i = 1;
                        foreach (var nom in nombres)
                        {
                            if (nom != null)
                            {
                                Console.WriteLine(i + "-" + nombres[i - 1] + "//" + telefonos[i - 1]);
                                i++;
                            }
                        }
                        Console.WriteLine("---------------------------------\n Elija el contacto a editar");
                        int z = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nuevo nombre");
                        nombres[z - 1] = Console.ReadLine();
                        Console.WriteLine("Nuevo numero telefonico");
                        telefonos[z - 1] = Console.ReadLine();

                        Console.WriteLine("CONTACTO EDITADO");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("---------------------------------\n Lista de todos los contactos");
                        i = 1;
                        foreach (var nom in nombres)
                        {
                            if (nom != null)
                            {
                                Console.WriteLine(i + "-" + nombres[i - 1] + "//" + telefonos[i - 1]);
                                i++;
                            }
                        }
                        Console.WriteLine("---------------------------------\n Elija el contacto a borrar");
                        int borrar = Convert.ToInt32(Console.ReadLine());
                        nombres[borrar - 1] = null;
                        telefonos[borrar - 1] = null;
                        i = 0; int k = 0;
                        foreach(var nom in nombres)
                        {
                            if (nombres[i] != null)
                            {
                                blanco[k] = nombres[i];
                                k++; 
                            }
                            i++;
                        }
                        foreach(var nom in nombres)
                        {
                            nombres = null;
                        }
                        nombres = blanco;
                        foreach(var blan in blanco)
                        {
                            blanco = null;
                        }
                        Console.WriteLine("Contacto borrado con exito");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Hasta luego");
                        Console.ReadKey();
                        final = false;
                        break;

                }
            }
            
        }
    }
}
