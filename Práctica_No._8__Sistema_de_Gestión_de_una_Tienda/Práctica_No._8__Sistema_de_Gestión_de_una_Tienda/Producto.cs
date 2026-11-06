using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_No._8___Sistema_de_Gestión_de_una_Tienda
{
    internal class Producto
    {
        private string nombre = "";
        private double precio = 0.0;
        private int cantidad = 0;
        public void Solicitar_Datos()
        {
            nombre = Leer_Texto("Ingrese el nombre del producto:");
            precio = Leer_Double_Positivo("Ingrese el precio del producto:");
            cantidad = Leer_Entero_Positivo("Ingrese la cantidad disponible del producto:");
        }
        private string Leer_Texto(string mensaje)
        {
            Console.WriteLine(mensaje);
            string entrada = Console.ReadLine()!;
            while (string.IsNullOrWhiteSpace(entrada))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: El campo no puede estar vacío. Intente nuevamente.");
                Console.ResetColor();
                Console.WriteLine(mensaje);
                entrada = Console.ReadLine()!;
            }
            return entrada;
        }
        private double Leer_Double_Positivo(string mensaje)
        {
            Console.WriteLine(mensaje);
            double entrada;
            while (!double.TryParse(Console.ReadLine(), out entrada) || entrada < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingrese un valor decimal válido y no negativo. Intente nuevamente.");
                Console.ResetColor();
                Console.WriteLine(mensaje);
            }
            return entrada;
        }
        private int Leer_Entero_Positivo(string mensaje)
        {
            Console.WriteLine(mensaje);
            int entrada;
            while (!int.TryParse(Console.ReadLine(), out entrada) || entrada < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingrese un valor entero válido y no negativo. Intente nuevamente.");
                Console.ResetColor();
                Console.WriteLine(mensaje);
            }
            return entrada;
        }
        public void Imprimir_Informacion_Producto()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" PRODUCTO");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Precio: $" + precio);
            Console.WriteLine("Cantidad disponible: " + cantidad);
            Console.ResetColor();
        }

        public double Calcular_Subtotal()
        {
            return precio * cantidad;
        }

    }
}
