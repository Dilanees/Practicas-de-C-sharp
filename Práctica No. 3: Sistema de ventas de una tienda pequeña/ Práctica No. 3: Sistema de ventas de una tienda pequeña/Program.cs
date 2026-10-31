using System;

namespace Practica_3_Sistema_de_ventas_de_una_tienda_pequeña
{
    class Program
    {
        static void Main()
        {

            bool salir = false;

            while (!salir)

            {

                Console.WriteLine("Hola, bienvenido al sistema de ventas de nuestra tienda SmallStore");
                Console.WriteLine("Dígame, ¿cuántas ventas tuvimos hoy?");
                string sells = Console.ReadLine()!;

                int ventas;
                while (!int.TryParse(sells, out ventas) || ventas <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Introduzca un número, no letras o caracteres extraños, tambien puede ser debido a poner demasiadas cifras de numeros, no queremos que tu pc explote jjsj:");
                    Console.ResetColor();
                    sells = Console.ReadLine()!;
                }
                Double[] Ventaz = new double[ventas];


                for (int i = 0; i < Ventaz.Length; i++)
                {
                    Console.WriteLine("ahora diganos, ¿cuanta plata ganamos en la venta numero" + (i + 1) + "?");
                    string plata = Console.ReadLine()!;
                    while (!double.TryParse(plata, out Ventaz[i]) || Ventaz[i] <= 0)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Introduzca un número, no letras o caracteres extraños :");
                        Console.ResetColor();
                        plata = Console.ReadLine()!;

                    }

                }


                double platatotal = 0;

                foreach (double platadeestaventa in Ventaz)
                {

                    platatotal = platatotal + platadeestaventa;
                }


                double promedio = platatotal / Ventaz.Length;

                int VentasMayoresAlPromedio = 0;
                foreach (double platadeestaventa in Ventaz)
                {

                    if (platadeestaventa > promedio)
                    {
                        VentasMayoresAlPromedio++;
                    }
                }




                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"El total de ventas de hoy es: {platatotal}");
                Console.WriteLine($"El promedio de ventas de hoy es: {promedio}");
                Console.WriteLine($"Ventas mayores al promedio son: {VentasMayoresAlPromedio}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPresiona ENTER para registrar otro venta o escribe 'salir' para cerrar.");
                //para que no transforme todas las letras del programa en verde, y solo se vea el mensaje en verde, y el resto del programa en blanco
                Console.ResetColor();

                // sirve para que el usuario pueda salir del programa cuando quiera, y no se quede atrapado en un bucle infinito
                if (Console.ReadLine()! == "salir")
                {
                    Console.WriteLine("¡Nos vemos!");
                    salir = true; // Esto rompe el bucle while y termina el programa



                }



            }

    }  
         }
}
