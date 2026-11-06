using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_No._8___Sistema_de_Gestión_de_una_Tienda
{
    internal class Cliente
    {


        private string nombre = "";
        private string correo = "";
        private string telefono = "";


        public void Solicitar_Datos()
        {
            nombre = Leer_Texto("Ingrese el nombre completo del cliente:");
            correo = Leer_Correo("Ingrese el correo del cliente:");
            telefono = Leer_Telefono("Ingrese el teléfono del cliente:");
        }

        private string Leer_Texto(string mensaje)
        {
            Console.WriteLine(mensaje);
            string entrada = Console.ReadLine()!;
            while (string.IsNullOrWhiteSpace(entrada))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: El nombre no puede estar vacío. Intente nuevamente.");
                Console.ResetColor();
                Console.WriteLine(mensaje);
                entrada = Console.ReadLine()!;





            }
            return entrada;

        }
        private string Leer_Correo(string mensaje)
        {
            Console.WriteLine(mensaje);
            string entrada = Console.ReadLine()!;
            while (string.IsNullOrWhiteSpace(entrada) || !entrada.Contains("@"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingrese un correo válido. Intente nuevamente.");
                Console.ResetColor();
                Console.WriteLine(mensaje);
                entrada = Console.ReadLine()!;
            }
            return entrada;
        }
        private string Leer_Telefono(string mensaje)
        {
            Console.WriteLine(mensaje);
            string entrada = Console.ReadLine()!;
            long numero;

            // Verifica que no esté vacío y que el texto ingresado sea un número válido
            while (string.IsNullOrWhiteSpace(entrada) || !long.TryParse(entrada, out numero))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: El teléfono debe contener únicamente números. Intente nuevamente.");
                Console.ResetColor();
                Console.WriteLine(mensaje);
                entrada = Console.ReadLine()!;
            }

            return entrada;
        }

        public void Imprimir_Informacion_Cliente()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
          
            Console.WriteLine("CLIENTE");
 

            Console.WriteLine("Nombre completo: " + nombre);
            Console.WriteLine("Correo: " + correo);
            Console.WriteLine("Teléfono: " + telefono);
            Console.ResetColor();
        }

    }
}



