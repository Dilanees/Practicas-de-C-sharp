using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_No._8___Sistema_de_Gestión_de_una_Tienda
{
    internal class Venta

    {
        private Cliente cliente = null!;

        private Producto producto = null!;

        private double subtotal = 0;

        private double descuento = 0;

        private double total = 0;

        public void Registrar_Venta(Cliente c, Producto p)
        {
            producto = p;
            cliente = c;

            subtotal = producto.Calcular_Subtotal();

            Calcular_Descuento();
            Calcular_Total();


        }

        public void Calcular_Descuento()
        {
            // Aplicar descuento según el subtotal, ordenado de mayor a menor para evitar algun error logico.
            if (subtotal >= 3000 )
          {
            descuento = subtotal * 0.10;
          }
          else if (subtotal >= 1000)
            {
                descuento = subtotal * 0.5;
            }
            else
            {
                descuento = 0;
            }
        }

        public void Calcular_Total()
        {
            total = subtotal - descuento;
        }

        public void Imprimir_Ticket()
        {   Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("            Ticket de Venta");
            Console.WriteLine("\n--------------------------------------");
            cliente.Imprimir_Informacion_Cliente();
            producto.Imprimir_Informacion_Producto();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine($"Subtotal: ${subtotal:0.00}");
            Console.WriteLine($"Descuento: ${descuento:0.00}");
            Console.WriteLine($"Total a Pagar: ${total:0.00}");
            Console.WriteLine("======================================");
            Console.ResetColor();

        }







    }
}
