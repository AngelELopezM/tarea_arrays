using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] frutas = new string[10];
            String[] vegetales = new string[10];
            String[] lacteos = new string[10];
            String[] blanco = new string[10];
            bool final = true;
            Console.WriteLine("Programa del super mercado \n");
            while (final)
            {
                int i = 0, numero = 1;
                
                Console.WriteLine("Elija una opcion \n 1-Agregar alimentos \n 2-Listar alimentos \n 3-Editar alimentos \n 4-borrar alimentos \n 5-Salir");
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    
                    case 1:/*Aqui agregamos comida*/
                        Console.WriteLine("Elija una categoria \n 1-Frutas \n 2-Vegetales \n 3-Lacteos"); //Aqui se empiezan a agregar alimentos
                        int agrega_alimentos = Convert.ToInt32(Console.ReadLine());
                        switch (agrega_alimentos)
                        {
                            case 1:
                                foreach (String frut in frutas)
                                {
                                    if (frut == null)
                                    {

                                        Console.WriteLine("Agregue una fruta");
                                        frutas[i] = Console.ReadLine();



                                        Console.WriteLine("Alimento añadido a la lista");
                                        Console.ReadKey();
                                        Console.Clear();
                                        
                                        break;
                                    }
                                    
                                    
                                    i++;//hasta aqui el programa me exploto porque el array se lleno
                                    if (i == 10)
                                    {
                                        Console.WriteLine("Las lista de frutas esta llena");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                }
                                
                                break;
                            case 2:
                                foreach (String veg in vegetales)
                                {
                                    if (veg == null)
                                    {
                                        Console.WriteLine("Agregue un vegetal");
                                        vegetales[i] = Console.ReadLine();

                                        Console.WriteLine("Alimento añadido");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    i++;
                                   
                                    if (i == 10)
                                    {
                                        Console.WriteLine("Las lista de vegetales esta llena");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                
                                break;
                            case 3:
                                foreach (String lac in lacteos)
                                {
                                    if (lac == null)
                                    {
                                        Console.WriteLine("Agregue un lacteo");
                                        lacteos[i] = Console.ReadLine();
                                        Console.WriteLine("Alimento añadido");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                    }
                                    i++;

                                    if (i == 10)
                                    {
                                        Console.WriteLine("Las lista de lacteos esta llena");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                
                                break;
                        }
                        break;
                    case 2: //Aqui listamos los alimento
                        Console.WriteLine("1-Listar todos los alimentos \n2-Listar por categoria");//Aqui abrimos otro Swtich para listar
                        int listar = Convert.ToInt32(Console.ReadLine());
                        switch (listar)
                        {
                            case 1:
                                Console.WriteLine("Lista de todas las frutas");
                                foreach (String frut in frutas)
                                {
                                    if (frut != null)
                                    {
                                          Console.WriteLine(numero + "-" + frut);
                                    }
                                    numero++;
                                }
                                Console.WriteLine("---------------------------------------------- \n Lista de todos los vegetales");
                                numero = 1; //Aqui reiniciamos la cuenta a 1 para la proxima lista
                                foreach (String veg in vegetales)
                                {
                                    if (veg != null)
                                    {
                                        Console.WriteLine(numero + "-" + veg);
                                    }
                                    numero++;
                                }
                                Console.WriteLine("---------------------------------------------- \n Lista de todos los lacteos");
                                numero = 1;//Aqui reiniciamos la cuenta a 1 para la proxima lista
                                foreach (String lact in lacteos)
                                {
                                    if (lact != null)
                                    {
                                        Console.WriteLine(numero + "-" + lact);
                                    }
                                    numero++;
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2://Aqui vamos a listar por categorias y por eso abrimos otro switch
                                Console.WriteLine("Elija una categoria \n 1-Frutas \n 2-Vegetales \n 3-Lacteos");
                                int cat = Convert.ToInt32(Console.ReadLine());
                                switch (cat)
                                {
                                    case 1: //Aqui listamos la categoria Frutas
                                        Console.WriteLine("Lista de todas las frutas");
                                        foreach (String frut in frutas)
                                        {
                                            
                                            if (frut != null)
                                            {
                                                Console.WriteLine(numero + "-" + frut);
                                            }
                                            numero++;
                                            
                                        }
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine("Lista de todas los vegetales");
                                        foreach (String veg in vegetales)
                                        {
                                            
                                            if (veg != null)
                                            {
                                                Console.WriteLine(numero + "-" + veg);
                                            }
                                            numero++;

                                        }
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        Console.WriteLine("Lista de todas los lacteos");
                                        foreach (String lact in lacteos)
                                        {
                                            
                                            if (lact != null)
                                            {
                                                Console.WriteLine(numero + "-" + lact);
                                            }
                                            numero++;

                                        }
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                }
                                break;
                        }
                        break;
                    case 3://Aqui vamos a editar los alimentos
                        Console.WriteLine("Elija la categoria que va a editar \n 1-Frutas \n 2-Vegetales \n 3-Lacteos");
                        int edit = Convert.ToInt32(Console.ReadLine());
                        switch (edit)
                        {
                            case 1://editar frutas
                                Console.WriteLine("Categoria de frutas");
                                foreach(var frut in frutas)
                                {
                                    if (frut != null)
                                    {
                                        Console.WriteLine(numero + "-" + frut);

                                    }
                                    numero++;
                                }
                                Console.WriteLine("Elija la fruta que desea editar");
                                int f = Convert.ToInt32(Console.ReadLine());
                                
                                    Console.WriteLine("Escriba el numero nombre");
                                    String n1 = Console.ReadLine();
                                    frutas[f - 1] = n1;
                                Console.WriteLine("------------------- \n Edicion exitosa");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2://editar vegetales
                                Console.WriteLine("Categoria de vegetales");
                                foreach (var veg in vegetales)
                                {
                                    if (veg != null)
                                    {
                                        Console.WriteLine(numero + "-" + veg);

                                    }
                                    numero++;
                                }
                                Console.WriteLine("Elija el vegetal que desea editar");
                                int f1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Escriba el numero nombre");
                                String n2 = Console.ReadLine();
                                vegetales[f1 - 1] = n2;
                                Console.WriteLine("------------------- \n Edicion exitosa");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 3://editar lacteos
                                Console.WriteLine("Categoria de lacteos");
                                foreach (var lact in lacteos)
                                {
                                    if (lact != null)
                                    {
                                        Console.WriteLine(numero + "-" + lact);

                                    }
                                    numero++;
                                }
                                Console.WriteLine("Elija el lacteo que desea editar");
                                int f2 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Escriba el numero nombre");
                                String n3 = Console.ReadLine();
                                lacteos[f2 - 1] = n3;
                                Console.WriteLine("------------------- \n Edicion exitosa");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                        break;
                    case 4://Aqui vamos a borrar los alimentos
                        Console.WriteLine("Desea borrar: \n 1-Todos los alimentos \n 2-Alimentos especificos");
                        int borrar = Convert.ToInt32(Console.ReadLine()) ;
                        switch (borrar)
                        {
                            case 1://Aqui borramos todos los alimentos
                                
                                frutas = blanco;
                                vegetales = blanco;
                                lacteos = blanco;
                                Console.WriteLine("--------------------- \nTodas las listas han sido borradas con exito!");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case 2://Aqui elejimos alimentos especificos
                                Console.WriteLine("Elija categoria: \n 1-Frutas \n2-Vegetales \n3-Lacteos");
                                int e = Convert.ToInt32(Console.ReadLine());
                                switch (e)//Aqui vamos a elejir la categoria para eliminar el alimento
                                {
                                    case 1://Eliminar alguna fruta
                                        foreach(var frut in frutas)
                                        {
                                            if(frut != null)
                                            {
                                                Console.WriteLine(numero+"-"+frut);
                                            }
                                            numero++;
                                        }
                                        Console.WriteLine("-------------\n Seleccione uno" );
                                        int borrar1 = Convert.ToInt32(Console.ReadLine());
                                        frutas[borrar1 - 1] = null;
                                        int z = 0,n=0;
                                        foreach (var frut in frutas)
                                        {

                                            if (frutas[z] != null)//Aqui le puse otra variable a blanco, porque asi se puede organizar todo bien dentro de el array de reindexar
                                            {
                                                blanco[n] = frutas[z];
                                                n++;

                                            }
                                            
                                            z++;

                                        }
                                        z = 0;
                                        foreach(var frut in frutas)
                                        {
                                            frutas[z] = null;
                                            z++;
                                        }
                                        z = 0;
                                        foreach(var blan in blanco)
                                        {
                                            if(blanco[z]!= null)
                                            {
                                                frutas[z] = blanco[z];
                                                z++;
                                            }
                                        }
                                        z = 0;
                                        foreach (var blan in blanco)
                                        {
                                            blanco[z] = null;
                                            z++;
                                        }

                                        break;
                                    case 2: //Eliminar algun vegetal
                                        foreach (var veg in vegetales)
                                        {
                                            if (veg != null)
                                            {
                                                Console.WriteLine(numero + "-" + veg);
                                            }
                                            numero++;
                                        }
                                        Console.WriteLine("-------------\n Seleccione uno");
                                        int borrar2 = Convert.ToInt32(Console.ReadLine());
                                        vegetales[borrar2 - 1] = null;
                                        int z1 = 0, n1 = 0;
                                        foreach (var veg in vegetales)
                                        {

                                            if (vegetales[z1] != null)//Aqui le puse otra variable a blanco, porque asi se puede organizar todo bien dentro de el array de reindexar
                                            {
                                                blanco[n1] = vegetales[z1];
                                                n1++;

                                            }

                                            z1++;

                                        }
                                        z1 = 0;
                                        foreach (var veg in vegetales)
                                        {
                                            vegetales[z1] = null;
                                            z1++;
                                        }
                                        z1 = 0;
                                        foreach (var blan in blanco)
                                        {
                                            if (blanco[z1] != null)
                                            {
                                                vegetales[z1] = blanco[z1];
                                                z1++;
                                            }
                                        }
                                        z1 = 0;
                                        foreach (var blan in blanco)
                                        {
                                            blanco[z1] = null;
                                            z1++;
                                        }
                                        break;
                                    case 3:
                                        foreach (var lact in lacteos)
                                        {
                                            if (lact != null)
                                            {
                                                Console.WriteLine(numero + "-" + lact);
                                            }
                                            numero++;
                                        }
                                        Console.WriteLine("-------------\n Seleccione uno");
                                        int borrar3 = Convert.ToInt32(Console.ReadLine());
                                        lacteos[borrar3 - 1] = null;
                                        int z3 = 0, n3 = 0;
                                        foreach (var lact in lacteos)
                                        {

                                            if (lacteos[z3] != null)//Aqui le puse otra variable a blanco, porque asi se puede organizar todo bien dentro de el array de reindexar
                                            {
                                                blanco[n3] = frutas[z3];
                                                n3++;

                                            }

                                            z3++;

                                        }
                                        z3 = 0;
                                        foreach (var lact in lacteos)
                                        {
                                            lacteos[z3] = null;
                                            z3++;
                                        }
                                        z3 = 0;
                                        foreach (var blan in blanco)
                                        {
                                            if (blanco[z3] != null)
                                            {
                                                lacteos[z3] = blanco[z3];
                                                z3++;
                                            }
                                        }
                                        z3 = 0;
                                        foreach (var blan in blanco)
                                        {
                                            blanco[z3] = null;
                                            z3++;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    case 5:
                        final = false;
                        Console.WriteLine("Hasta luego!! =)");
                        break;
                }
            }
        Console.ReadKey();
        }
    }
}
