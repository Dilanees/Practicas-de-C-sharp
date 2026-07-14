namespace Práctica_No._2_Adivina_el_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables definidas como enteros y string
            string Nombre;
            int numeritomisteriosin;
            int intentos = 5;
            int intentos_r = 0;
            int usernumero;

            bool ganaste = false;  // significa que el usuario no ha ganado todavía, y se usara para saber si el usuario gano o perdio al final del juego

            // Esto sirve para generar un número aleatorio entre 1 y 100
            Random generador = new Random();
            numeritomisteriosin = generador.Next(1, 101);

            //Saludamos al usuario y le pedimos su nombre
            Console.WriteLine("Hola Bienvenido Usuario, Yo soy un algoritmo, y vos como te llamas? ");
           Nombre = Console.ReadLine()!;

            // le explicamos al usuario de que tratara el juego + agregamos (+ nombre +) para que aparezca el nombre que el usuario ingreso antes
            Console.WriteLine("Gusto conocerte " + Nombre + ", hoy jugaremos a frio calor.");
            Console.WriteLine("Tendras que escribir un numero del 1 al 100, y yo te ire diciendo:");
            Console.WriteLine("Muy Frio = Lejisimos");
            Console.WriteLine("Frio = Lejos");
            Console.WriteLine("Tibio = No tan lejos");
            Console.WriteLine("Caliente = Cerca");
            Console.WriteLine("Muy Caliente = Super Cerca");
            Console.WriteLine("Ahora sabiendo esto, ¡COMENCEMOS!\n");


            while (intentos_r < intentos)
            {
                Console.WriteLine("Escribe tu número:");
                usernumero = Convert.ToInt32(Console.ReadLine());

                // Ayuda a evitar errores de logica, si el usuario ingresa un número fuera del rango de 1 a 100, se le pedirá que ingrese un número válido
                if (usernumero < 1 || usernumero > 100)
                {
                    Console.WriteLine("Te confundiste, tiene que ser un numero del 1 al 100, intenta de nuevo.\n");
                    continue;
                }

                intentos_r++; //sin esto, no se le restarian los intentos al usuario, y el juego seria infinito

                int diferencia = Math.Abs(numeritomisteriosin - usernumero); // sirve para calcular la diferencia entre el número secreto y el número ingresado por el usuario, para poder decirle si esta cerca o lejos de adivinar el número secreto

                if (usernumero == numeritomisteriosin) // se pone para que el si el usuario adivina el numero aleatorio, se le muestre un mensaje de que gano
                {
                    Console.WriteLine("¡BINGO! Adivinaste el número secreto.");
                    ganaste = true; // Se usa para indicar que Ganaste :)
                    break;
                }

                // ponemos esto para que el usuario pueda ver cuan cerca o lejos esta de adivinar el numero secreto
                if (diferencia <= 5)
                    Console.WriteLine("Muy Caliente");
                else if (diferencia <= 10)
                    Console.WriteLine("Caliente");
                else if (diferencia <= 20)
                    Console.WriteLine("Tibio");
                else if (diferencia <= 30)
                    Console.WriteLine("Frio");
                else
                    Console.WriteLine("Muy frio");
                // Le decimos al usuario cuantos intentos le quedan
                Console.WriteLine("Te quedan " + (intentos - intentos_r) + " intentos.\n");
            } 
            // Si el usuario no adivina el número secreto después de 5 intentos, se le mostrará un mensaje indicando que perdió y cuál era el número secreto
            if (ganaste == false) // se usa para indicar que perdiste :(
            {
                Console.WriteLine("Lamente decir que has perdido, El número secreto era: " + numeritomisteriosin);// sirve para mostrarle el numero al usuario
            }
            // sirve para que el programa no se cierre de golpe
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
        }
    }

