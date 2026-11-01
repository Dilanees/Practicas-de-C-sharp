namespace Practica_No._5_Diccionario_de_Programacion_con_CRUD

{
    internal class Program
    {


        static void Mostrar_Menu()
        {
            Console.WriteLine("Hola, bienvenido usuario!!!!");
            Console.WriteLine("bienvenido al diccionario para agregar terminos de programacion");
            Console.WriteLine("Empecemos a crear el diccionario");
            
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(" 1. Agregar Termino sjkjsjsjs");
            Console.WriteLine(" 2. Mostrar Terminos");
            Console.WriteLine(" 3. Buscar Termino");
            Console.WriteLine(" 4. Actualizar Termino");
            Console.WriteLine(" 5. Eliminar Termino");
            Console.WriteLine(" 6. Salir");
            Console.WriteLine("");
            Console.Write("\n Elige la opcion que quieras jeje (DEBERIAS ESCOGER LA OPCION 1 PARA EMPEZAR): ");


        }


        static void Agregar_Termino(String[] terminos, String[] Definicion, ref int Contador)
        {

            Console.WriteLine("Ingresa el nombre del termino:");
            terminos[Contador] = Console.ReadLine()!;

            while (string.IsNullOrWhiteSpace(terminos[Contador]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: El término no puede estar vacío. Intenta de nuevo.");
                Console.ResetColor();

                terminos[Contador] = Console.ReadLine()!;
            }


            Console.WriteLine("Ingresa la definicion del termino:");
            Definicion[Contador] = Console.ReadLine()!;

            while (string.IsNullOrWhiteSpace(Definicion[Contador]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: La definición no puede estar vacía. Intenta de nuevo.");
                Console.ResetColor();

                Definicion[Contador] = Console.ReadLine()!;
            }
            Contador++;

        }
        static void Mostrar_Termino(String[] terminos, String[] Definicion, int Contador)

        {
            Console.WriteLine("Aqui estan todos los terminos:");
            for (int i = 0; i < Contador; i++)
                if (terminos[i] != null)
                {
                Console.WriteLine("Termino: " + terminos[i]);
                Console.WriteLine("Definicion: " + Definicion[i]);
            }
        }
        static void Buscar_Termino(String[] terminos, String[] Definicion, int Contador)

        {
            bool TerminoEncontrado = false;


            Console.WriteLine("Ingresa el Termino que deseas buscar:");
            string terminoBuscado = Console.ReadLine()!;

            for (int i = 0; i < Contador; i++)
            {
                if (terminos[i] == terminoBuscado)
                {
                    Console.WriteLine("Termino: " + terminos[i]);
                    Console.WriteLine("Definicion: " + Definicion[i]);
                    TerminoEncontrado = true;
                }
            }

            if (!TerminoEncontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo siento, el termino no fue encontrado :( .");
            }
            Console.ResetColor();

        }

        static void Actualizar_Termino(String[] terminos, String[] Definicion, int Contador)
        {


            Console.WriteLine("que termino deseas actualizar?");

            bool TerminoEncontrado = false;

            string terminoBuscado = Console.ReadLine()!;

            for (int i = 0; i < Contador; i++)
            {
                if (terminos[i] == terminoBuscado)
                {
                    Console.WriteLine("Termino encontrado!!!!!!");
                    Console.WriteLine("Termino: " + terminos[i]);
                    Console.WriteLine("Definicion: " + Definicion[i]);




                    Console.WriteLine("Ingresa el nuevo termino:");
                    terminos[i] = Console.ReadLine()!;
                    Console.WriteLine("Ingresa la nueva definicion:");
                    Definicion[i] = Console.ReadLine()!;

                    Console.WriteLine("Termino actualizado con exito!!!!!!");  
                    TerminoEncontrado = true;
                }
            }

            if (!TerminoEncontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo siento, el termino no fue encontrado :(, y peor no se puede actualizar .");
            }
            Console.ResetColor();


        }

        static void Eliminar_Termino(string[] terminos, string[] definicion, int contador)
        {
            Console.WriteLine("Ingresa el termino que deseas eliminar:");
            string terminoBuscado = Console.ReadLine()!;
            bool TerminoEncontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (terminos[i] == terminoBuscado)
                {
                    terminos[i] = null!;
                    definicion[i] = null!;
                    TerminoEncontrado = true;
                    Console.WriteLine("Termino eliminado con exito!!!!!!");
                }
            }
            if (!TerminoEncontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo siento, el termino no fue encontrado :(, y peor no se puede eliminar .");
            }
            Console.ResetColor();
        }







        static void Main(string[] args)
        {

            




            bool salir = false;

            string[] terminos = new string[50];
            string[] definicion = new string[50];
            int contador = 0;

            while (!salir)
            {
                Console.Clear();
                Mostrar_Menu();

                string? opción = Console.ReadLine();
                Console.WriteLine();

                switch (opción)
                {
                    case "1":
                        Agregar_Termino(terminos, definicion, ref contador);
                        break;

                    case "2":

                        if (contador == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No hay términos para mostrar, tiene que agregar terminos primero");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                        else
                            Mostrar_Termino(terminos, definicion, contador);
                        Console.ReadKey();
                        break;

                    case "3":
                        if (contador == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Primero debes crear un termino");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                        else
                            Buscar_Termino(terminos, definicion, contador);
                        Console.ReadKey();
                        break;

                    case "4":
                       

                        if (contador == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Primero debes crear un termino");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Actualizar_Termino(terminos, definicion, contador);

                        }
                        Console.ReadKey();
                        break;

                    case "5":

                       if (contador == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Primero debes crear un termino");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Eliminar_Termino(terminos, definicion, contador);
                            Console.ReadKey();
                            break;
                        }
                     
                    case "6":
                        salir = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" Nos vemos la proxima!!!!.");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Opción inválida, no podes poner cosas que no aparecen en las opciones");
                        Console.ResetColor();
                        Console.ReadKey(); // si no ponemos esto el texto se ejecutaria a la velocidad de la luz y no lo veriamos
                        break; // siempre va al final de todo para que no haya problemas como por ejemplo que no se muestre el texto







                }
            }


        }

    }

}

 