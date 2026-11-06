using System.IO.Pipes;

namespace Práctica_No._7___Sistema_de_Registro_de_Empleados
{//las clases son como un molde o una plantilla
    internal class Program
    { 
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {

                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Hola bienvenido a:");
                Console.WriteLine("=============================================");
                Console.WriteLine("   SISTEMA DE REGISTRO DE EMPLEADOS");
                Console.WriteLine("=============================================");


                // Dibujo de EMPLEADO
                string dibujo = @"⠀⠀⠀
⡑⠈⠀⠃⠈⡐⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣾⠿⠿⡛⣛⢛⡛⣛⢛⡻⢶⣦⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠄⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⣿⣿⠿⡚⣬⢣⡕⡚⢦⡙⣆⢳⢸⡑⢎⡹⢛⠿⣶⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠤⠀⠤⠀⠠⠄⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⢟⣫⠒⡧⠳⣌⠇⣎⠝⣢⠝⣌⢣⢣⡙⢎⡵⢩⡚⢴⢻⣿⣇⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡐⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⣤⣿⠋⠉⢹⡧⢎⡽⡑⢯⣐⢫⠬⣙⠦⣙⡌⣣⢣⡙⢎⡼⣡⢝⣢⢋⢿⣿⣷⣂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀
⠄⠀⠀⠀⠀⠀⠠⠀⠀⠀⠠⣴⡟⠈⠀⢀⣾⠹⣘⠦⣙⠆⡞⡰⡍⢦⠓⣥⢪⡑⢦⠹⣌⠲⢥⡚⡔⣫⠜⣻⡿⣧⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⢳⣦⣤⢾⡙⢆⠯⡔⢫⡔⢣⢣⢕⡊⡖⡍⢮⡑⢎⢦⡙⠦⡜⣡⠳⡍⠶⣙⣧⢿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡈⠀⠀⠀⠀⠀⠀⠀⠀⠀⢼⡿⣼⣼⢣⠖⡭⢎⡕⢮⠱⣘⢣⢣⠚⡜⡴⡙⢦⡙⢎⢦⡙⡼⢌⡥⢳⢸⡹⢤⢻⡾⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠄⠀⠀⠀⠀⠀⠀⠀⠀⠠⣾⡇⣿⢣⢇⡺⡑⢮⡘⢦⠛⣌⠇⣇⡛⡜⠴⣙⢦⡙⣬⠒⣥⠓⣎⠴⣃⠧⣙⢦⣛⡶⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢂⠀⠀⠀⠀⠀⠀⠀⠀⠐⣿⡏⣟⠦⡓⡴⡙⢦⣙⢦⡛⡬⣙⠦⡱⢎⢳⠱⢦⡙⡴⢋⡶⡩⢆⡳⢜⡜⣱⠲⣼⣛⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠄⠀⠀⠀⠀⠀⠀⠀⠀⠰⣿⡗⣿⠬⣱⢒⣭⣖⡘⢦⢳⡱⢎⡺⣑⢎⡣⢝⣢⣵⣮⣇⠶⣙⠮⣑⠮⡜⣥⠓⣞⣳⣾⡇⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣧⣿⢲⢡⣾⡟⣿⣿⣌⠣⠞⡥⢳⣉⢦⢹⢸⣏⢘⣿⣿⡞⣌⠧⣃⠞⡜⢦⢋⡿⣥⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠡⠀⠀⠀⠀⠀⠀⠀⠀⠀⢛⣿⣼⣧⢣⢻⣧⣾⣿⣧⢋⡝⣌⠧⡜⡬⢃⡎⣿⣿⣿⣿⣟⠴⡹⣐⢫⡜⢥⡿⣝⣾⠗⣶⠀⠀⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠂⠀⠀⠀⠀⠀⠠⠀⠀⠀⠀⢿⣷⣻⣎⠖⣹⢿⣿⠗⣣⠜⣢⠝⣰⣍⢣⡜⢬⡛⣟⢻⡉⠶⡱⣉⠶⣘⡾⣽⡿⠓⢦⣿⣦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠁⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣷⣝⣯⡦⡙⢦⡙⢦⡙⡼⣿⣿⣿⠣⣜⢣⣜⢢⢇⠺⣑⢣⡍⢶⣹⣿⣿⣆⣷⣿⣿⣿⣿⣿⣷⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠈⠘⠻⣮⣳⢯⡒⢭⡒⡱⢎⠲⡍⢦⢹⡐⢧⣘⡒⢮⣱⣉⣶⣾⢿⣿⣅⣬⣙⡟⠻⣿⣿⣿⣿⣿⣿⣿⣦⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⡀⠀⠙⠛⠾⢷⣮⣵⣧⣜⣦⣱⣎⣬⣳⣬⣽⣷⡾⣿⢿⡻⣝⢮⣽⣿⣿⣟⡷⣆⡙⢿⣿⣿⣿⣿⣿⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⢏⢩⡙⡛⡛⡛⢏⢻⡙⢎⢓⠛⣒⠩⢬⣿⠫⢖⡩⢞⣿⡽⣧⠊⣿⣿⣿⣿⣿⣿⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣶⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⢿⡿⣿⣿⣿⣿⣿⣿⡿⣿⣷⢊⡼⣿⣹⡆⢾⣿⣿⣿⣿⣿⣿⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣿⠂⠤⢠⠤⡐⣠⠆⡔⠄⠤⡰⢠⠒⡠⠄⠤⡠⠄⡔⠠⠄⢤⠠⠤⠠⢄⠰⡀⢆⠰⠠⢄⠢⢄⠤⢢⢴⣿⣿⢪⠔⣿⡽⣏⠸⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢹⡎⠄⢣⡐⢌⡰⢨⡐⡉⢆⡑⢢⠑⢤⢉⠆⣡⠊⡔⡡⠚⡄⢣⢌⠱⡈⢆⠱⡈⠦⡑⢌⠢⠅⢎⢀⢺⣿⣿⢣⡚⣵⢯⣇⢂⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠸⣇⠘⡰⢈⠔⢢⠃⡤⠃⠆⡜⠤⡉⠆⢡⣈⡄⡉⠔⢡⠃⡜⡠⠊⡔⢡⠊⢆⡑⠢⢅⠊⡔⢩⠐⡌⠠⣿⣿⡧⣹⢾⣽⠃⢾⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣿⠠⠱⡈⢄⠣⢎⠰⢉⡒⠌⡒⢁⡾⠋⠀⠀⠙⢮⣠⣑⠠⠃⡕⣠⠂⡍⠒⡌⢡⢂⠱⡘⠤⡑⠤⢃⢻⣿⣧⢟⣿⡏⢄⣿⣿⣿⣻⣿⡿⠿⠿⠿⠻⢷⠶⣤⣤⣀⡄⠀⠀⠀⠀
⠀⣿⡄⢓⠨⢄⢋⠤⢃⠥⣘⠢⡑⢨⠃⠀⠀⠀⠀⠀⠀⠉⠳⣅⠐⢢⡑⢌⡑⢌⡁⢎⠰⢡⠒⡌⠒⡠⢺⣿⣯⣿⣿⡇⡈⣿⣿⢿⣿⣧⣧⣴⣴⣴⣶⣶⣾⣮⣿⡿⢿⡄⠀⠀⠀
⠀⢸⡇⡘⠰⡈⢎⢒⡡⠒⡄⠣⠜⡀⢧⡀⠀⠀⠀⠀⠀⠀⠀⠘⡌⡐⢌⠢⡘⢄⠎⣠⠓⣂⠱⡈⢆⠱⢈⣿⣿⡓⣾⣧⠰⣿⣿⡀⠉⠉⠉⠉⠉⠉⠉⠉⠉⠁⠀⡆⣿⡟⢲⣆⠀
⠀⢸⡇⠸⢡⢘⢂⠦⡑⡘⠤⡙⢂⠅⡂⠙⡄⠀⠀⠀⠀⠀⠀⠀⠈⡔⢈⠦⢉⠆⢎⠰⠠⡅⢒⢡⠘⡄⠃⣿⣧⢻⠴⣿⣇⠹⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⢸⠇⣾⣷⣄⠙⢷
⠀⢸⣷⢂⡘⠌⡜⢠⢃⠱⡀⢇⢊⠔⣃⠂⢇⠀⠀⠀⠀⣀⠀⠀⡰⠡⡘⡄⡊⠔⡌⣐⠢⡑⠬⡈⢆⠡⠂⣽⣿⣎⢶⣩⠿⣦⣿⠂⠀⠀⠀⠀⠀⠀⠀⠀⠂⠀⣾⠀⣿⡏⢻⡐⣼
⠀⠀⣿⠠⢘⠰⢨⠅⡊⠔⡡⢊⡐⢊⠔⡌⢂⣉⠡⢊⠡⡐⢨⠁⢆⡑⢂⢒⠡⢃⠒⡄⢃⠜⡠⢑⡈⢆⠑⣼⣿⢛⣟⡻⣿⣿⣿⠀⠠⠀⠀⠀⠀⠀⠀⠀⠀⢐⡏⡐⣿⣷⠏⢰⣾
⠀⠀⣿⠐⡈⢆⡑⢊⠡⡘⠄⢣⠘⡌⠒⠌⢒⠨⡑⠌⢢⢁⠣⡉⠆⡰⢁⠎⡑⢌⠒⠨⠌⢢⠑⢢⠐⡌⢢⢸⣿⢷⢾⠻⣝⢧⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⠡⢀⣿⡇⣬⠾⠁
⠀⠀⣿⢈⡐⠢⠌⠆⢣⠘⠌⢢⠑⠤⠃⡍⠢⡑⠬⠘⠤⠊⡔⠡⠒⡁⠆⡜⠰⠨⢌⠑⡊⠅⠎⡄⠣⢘⢀⢺⣿⣭⣮⣿⠿⠛⣿⠀⠈⠀⠀⠀⠀⠀⠀⠀⢠⡏⠠⢡⣼⣏⠁⠀⠀
⠀⠀⢻⣧⣴⣥⣮⣬⣦⣼⣼⣤⣮⣴⣥⣦⣷⣴⣮⣵⣦⣷⣴⣧⣵⣼⣴⣦⣥⣧⣦⣾⣴⢾⣴⣶⣵⣾⣦⣾⡿⠋⢋⣀⠀⠀⢉⢛⠶⢦⣤⣶⣶⣖⣲⣶⣾⣤⠿⣟⡋⠁⠀⠀⠀
         ";

                Console.WriteLine(dibujo);



                Empleado empleado1 = new Empleado();

                // 2. Ejecutamos tu método de preguntas
                empleado1.Solicitar_Datos();

                empleado1.Calcular_Salario();

                empleado1.Imprimir_Informacion();

                empleado1.Categoria_Empleado();
                 Console.ReadKey(true);


                // sirve para darle color al texto que se imprime en consola
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPresiona ENTER para registrar mas empleados o escribe 'salir' para cerrar.");
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
