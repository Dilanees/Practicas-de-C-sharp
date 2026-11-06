namespace Práctica_No._8___Sistema_de_Gestión_de_una_Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Cliente cliente = new Cliente();
                Producto producto = new Producto();
                Venta venta = new Venta();

                Console.WriteLine("Hola, bienvenido a nuestro; ");

                Console.WriteLine("=============================== ");
                Console.WriteLine(" SISTEMA DE GESTIÓN DE VENTAS ");
                Console.WriteLine("=============================== ");

                cliente.Solicitar_Datos();
                producto.Solicitar_Datos();
                venta.Registrar_Venta(cliente, producto);
                venta.Imprimir_Ticket();

                // sirve para darle color al texto que se imprime en consola
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPresiona ENTER para registrar mas empleados o escribe 'salir' para cerrar.");
                Console.ResetColor(); //para que no transforme todas las letras del programa en verde, y solo se vea ese texto en verde, y el resto del programa en blanco

                // esto sirve para que el programa detecte la variable  respuesta, y usamos ToLower() para que no importe si el usuario escribe "salir" en mayúsculas o minúsculas
                string respuesta = Console.ReadLine()!.ToLower();
               

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
