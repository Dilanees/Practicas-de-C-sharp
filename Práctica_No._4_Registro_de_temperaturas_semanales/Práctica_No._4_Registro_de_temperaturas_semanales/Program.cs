using System.Numerics;

namespace Práctica_No._4_Registro_de_temperaturas_semanales
{
    internal class Program
    {
        static void Main(string[] args)


        {

            // el bool salir = false; sirve para que el usuario pueda salir del programa cuando quiera, y no se quede atrapado en un bucle infinito
            bool salir = false;

            //puse todo el codigo en un bucle while para que el usuario pueda usar el sistema las veces que quiera, sin tener que reiniciar el programa 
            while (!salir)

            {
               
                //mensaje de bienvenida al usuario
                Console.WriteLine("Buenas Buenas, soy Terperito, su asistente relacionado con las temperaturas");

                //le pedimos al usuario ingresar las temperaturas de los 7 dias de la semana
                Console.WriteLine("Asi que necesitare que ingrese la temperatura de los 7 dias de la semana");

                //estamos creando los arreglos
                double[] temperaturas = new double[7];

                //usaremos este ciclo for paar no tener que escribir el mismo mensajes 7 veces y crear 7 variables distintas
                for (int i = 0; i < 7; i++)
                {   
                    
                    Console.WriteLine("Porfavor ingrese la temperatura del dia " + (i + 1));
                    //creamos una variable y ponemos console.readline para que el usuario pueda escribir
                   string entrada = Console.ReadLine()!;

                    // usamos este bucle while con un double tryparse para evitar que el usuario escriba caracteres o signos
                    while (!double.TryParse(entrada, out temperaturas[i]))
                    {
                        //para que las respuestas de error se vean en rojo y el usuario pueda darse cuenta que escribio algo mal
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Introduzca un número, no letras o caracteres extraños :");

                        //para que no transforme todas las letras del programa en rojo, y solo se vea el error en rojo, y el resto del programa en blanco
                        Console.ResetColor();
                        //sirve para que el usuario pueda escribir de nuevo
                        entrada = Console.ReadLine()!;

                    }


                }


              
                // Preparamos y creamos las variables, Empezamos el total en 0. 
                double TempTotal = 0;
                double Maximo = temperaturas[0];
                double tempMinima = temperaturas[0];


              
                // Recorremos la lista completa de temperaturas. 'Nowadays' representa la temperatura que estamos mirando en este momento.
                foreach (double Nowadays in temperaturas)
                {
                    // Sumamos la temperatura actual al total de la semana
                    TempTotal = TempTotal + Nowadays;

                    // Si la temperatura que estamos mirando es mayor a la que teníamos guardada como máxima, la reemplazamos
                    if (Nowadays > Maximo)
                    {
                        Maximo = Nowadays;
                    }

                    // Lo mismo para la mínima: si encontramos una más baja, la guardamos
                    if (Nowadays < tempMinima)
                    {
                        tempMinima = Nowadays;
                    }
                }

                // Ahora que tenemos el total real, lo dividimos por 7 para sacar el promedio
                double promedio = TempTotal / 7;

                // Preparamos y creamos dos variables con contadores en 0 para saber cuántos días estuvieron arriba o abajo del promedio
                int Superiores = 0;
                int Inferiores = 0;

                // Limpiamos la consola para que el reporte se vea prolijo
                Console.Clear();

                // Volvemos a revisar la lista de temperaturas desde el principio
                foreach (double Nowadays in temperaturas)
                {
                    // Habia puesto doble del mismo, y eso me daria doble suma, solo lo puse en los comentarios para que veas que lo intente
                    // TempTotal = TempTotal + Nowadays;

                    // Si el día actual superó el promedio de la semana, le sumamos 1 al contador
                    if (Nowadays > promedio)
                    {
                        Superiores++;
                    }

                    // Si el día actual fue menor al promedio de la semana, le sumamos 1 al otro contador
                    if (Nowadays < promedio)
                    {
                        Inferiores++;
                    }
                }

                // Imprimimos la temperatura que hizo cada uno de los 7 días
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Dia " + (i + 1) + " Temperatura: " + temperaturas[i]);
                }

                // Cambiamos el color a amarillo para resaltar los resultados estadísticos
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("La temperatura mas alta fue: " + Maximo);
                Console.WriteLine("La temperatura mas baja fue: " + tempMinima);
                Console.WriteLine("La total fue: " + TempTotal);
                Console.WriteLine("Días por encima del promedio: " + Superiores);
                Console.WriteLine("Días por debajo del promedio: " + Inferiores);
                Console.ResetColor(); //para que no transforme todas las letras del programa en amarillo, y solo se ese texto en rojo, y el resto del programa en blanco



                // Cambiamos el color a verde para las instrucciones finales
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPresiona ENTER para registrar otras temperaturas semanales o escribe 'salir' para cerrar.");
                string respuesta = Console.ReadLine()!;
                Console.ResetColor(); //para que no transforme todas las letras del programa en verde, y solo se vea ese texto en verde, y el resto del programa en blanco

                // Si el usuario escribe "salir", nos despedimos y rompemos el bucle
                if (respuesta == "salir")
                {
                    Console.WriteLine("Bueno, entonces eso fue todo por hoy");
                    Console.WriteLine("Gracias por usarme y nos vemos en otra ocasion");
                    Console.WriteLine("Chauuu");
                    Console.ReadKey();
                    salir = true; // Esto hace que el bucle while termine
                }
























            }
     
        }
        } 
    } 