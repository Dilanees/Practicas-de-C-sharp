



//mensajes de bienvenidas al trabajador
Console.WriteLine("Hola empleado, bienvenido al sistema de control de cobre de vehiculos");

// Dibujo de un caro
string dibujo = @"⠀⠀⠀                             
                          _.--""""'-----,   `""--.._
                       .-''   _/_      ; .'""----,`-,
                     .'      :___:     ; :      ;;`.`.
                    .      _.- _.-    .' :      ::  `..
                 __;..----------------' :: ___  ::   ;;
            .--"""". '           ___.....`:=(___)-' :--'`.
          .'   .'         .--''__       :       ==:    ;
      .--/    /        .'.''     ``-,   :         :   '`-.
   .""', :    /       .'-`\\       .--.\ :         :  ,   _\
  ;   ; |   ;       /:'  ;;      /__  \\:         :  :  /_\\
  |\_/  |   |      / \__//      /""--\\ \:         :  : ;|`\|    
  : ""  /\__/\____//   """"""      /     \\ :         :  : :|'||
[""""""""""""""""""--------........._  /      || ;      __.:--' :|//|
 ""------....______         ].'|      // |--""""""'__...-'`\ \//
   `| WVE230L |__;_...--'"": :  \    //  |---""""""      \__\_/
     """"""""""""""""""'            \ \  \_.//  /
       `---'                \ \_     _'
                             `--`---'  dp
  ";
Console.WriteLine(dibujo);

Console.WriteLine("para poder saber bien los precios porfavor ingrese la hora de entrada y salida del vehiculo");



// el bool salir = false; sirve para que el usuario pueda salir del programa cuando quiera, y no se quede atrapado en un bucle infinito
bool salir = false;

//puse todo el codigo en un bucle while para que el usuario pueda usar el sistema las veces que quiera, sin tener que reiniciar el programa 
while (!salir)

{

    //estamos definiendos las variables como enteros (int)
    int horaEntrada;
    int horaSalida;
    int tiempoTotal;
    //una variable con un valor especifico definida como entero (int)
    double PlataQueGanaraElNegocio = 0;



    //le estamos pidiendo al usuario que use este sistema que ingrese la hora de entrada del vehiculo
    Console.WriteLine("Hora de entrada del vehiculo");

   
    //sirve para que el usuario pueda escribir una repuesta
   string entrada = Console.ReadLine()!;

    // sirve para que el usuario no pueda escribir letras, simbolos, numeros negativos, o 0, y solo pueda escribir numeros del 1 al 24
    if (!int.TryParse(entrada, out horaEntrada) || horaEntrada <= 0 || horaEntrada > 24)
    {   //para que las respuestas de error se vean en rojo y el usuario pueda darse cuenta que escribio algo mal
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Ingresa un número válido entre 1 y 24. No se aceptan 0, negativos ni símbolos.");
        Console.ResetColor();
        continue; // Reinicia el bucle desde el principio
    }








    //le estamos pidiendo al usuario que use este sistema que ingrese la hora de salida del vehiculo
    Console.WriteLine("Hora de salida del vehiculo");

    //nos esta dando errores de logica, por eso lo comente, pero lo deje para que veas que lo intente
    //horaSalida = Convert.ToInt32(Console.ReadLine());

    string salida = Console.ReadLine()!;

    if (!int.TryParse(salida, out horaSalida) || horaSalida <= 0 || horaSalida > 24)
    {   //para que las respuestas de error se vean en rojo y el usuario pueda darse cuenta que escribio algo mal
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Ingresa un número válido entre 1 y 24. No se aceptan 0, negativos ni símbolos.");
        //para que no transforme todas las letras del programa en rojo, y solo se vea el error en rojo, y el resto del programa en blanco
        Console.ResetColor();
        continue;
    }

    //la asignamos a la variable tiempoTotal
    tiempoTotal = horaSalida - horaEntrada;

    //esto ayudara a que podamos dependiendo del tiempo que puso el usuario que estuvo un vehiculo, cobrarle una cantidad concreta
    // el primer if hace que un vehiculo que este mas de 8 horas en el estacionamiento, se le cobre solamente 180, sin aumentar el precio 

    if (tiempoTotal > 8)
    {
        PlataQueGanaraElNegocio = 180;
    }
    // el esle if, en este caso, dice que sino si el vehiculo estuvo una hora o menos, se le cobre solo 30
    else if (tiempoTotal <= 1)
    {
        PlataQueGanaraElNegocio = 30;
    }
    // el else, en esta caso, sirve para que sino es ninguna de las anteriores, y estuvo mas de una hora pero no ocho horas, se le cobre 30 por la primera hora, y cada hora extra se le cobrara 20 mas
    else
    {
        int horasExtra = tiempoTotal - 1;
        PlataQueGanaraElNegocio = 30 + (horasExtra * 20);
    }

    // antes le habia puesto signo igual al if, pero eso me daba errores de logica, por eso lo quite, y ahora funciona perfecto
    //if (horaSalida <= horaEntrada)

    // esto nos ahorra errores de logica de si por alguna razon el usuario escribe las horas al reves, ejemplo, de 9 a 7 enves de 7 a 9
    if (horaSalida < horaEntrada)
    {  //para que las respuestas de error se vean en rojo y el usuario pueda darse cuenta que escribio algo mal
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: La hora de salida debe ser mayor a la de entrada, escribi bien porfavor.");
        //para que no transforme todas las letras del programa en rojo, y solo se vea el error en rojo, y el resto del programa en blanco
        Console.ResetColor();

        //lo puse para que no aparezca el total a cobrar, ya que seria algo ilogico y tambien para que el usuario pueda escribir las horas de nuevo
        continue;

        // lo saque porque te sacaba del bucle y no te dejaba volver a escribir las horas, pero lo deje comentado para que veas que lo intente
        //Environment.Exit(0);
    }

    //para que las respuestas se vean en verde y el usuario pueda darse cuenta que es un mensaje mas importante
    Console.ForegroundColor = ConsoleColor.Yellow;
    //le decimos al usuario el total que le tiene que cobrar al vehiculo
    Console.WriteLine("El total a cobrar al sujeto que dejo su vehiculo es: $" + PlataQueGanaraElNegocio);
    // //para que no transforme todas las letras del programa en amarillo, y solo se vea el mensaje en amarillo, y el resto del programa en blanco
    Console.ResetColor();
    //para que las respuestas se vean en verde y el usuario pueda darse cuenta que es un mensaje mas importante
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nPresiona ENTER para registrar otro vehículo o escribe 'salir' para cerrar.");
    //para que no transforme todas las letras del programa en verde, y solo se vea el mensaje en verde, y el resto del programa en blanco
    Console.ResetColor();

    // sirve para que el usuario pueda salir del programa cuando quiera, y no se quede atrapado en un bucle infinito
    if (Console.ReadLine()!.ToLower() == "salir")
    {
        salir = true; // Esto rompe el bucle while y termina el programa
    }

}