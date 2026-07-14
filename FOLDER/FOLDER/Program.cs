//estamos definiendos las variables como enteros (int)
int horaEntrada;
int horaSalida;
int tiempoTotal;
//una variable con un valor especifico definida como entero (int)
double PlataQueGanaraElNegocio = 0;

//mensajes de bienvenidas al trabajador
Console.WriteLine("Hola empleado, bienvenido al sistema de control de cobre de vehiculos");
Console.WriteLine("para poder saber bien los precios porfavor ingrese la hora de entrada y salida del vehiculo");

//le estamos pidiendo al usuario que use este sistema que ingrese la hora de entrada del vehiculo
Console.WriteLine("Hora de entrada del vehiculo");

//sirve para que el usuario pueda escribir una repuesta
horaEntrada = Convert.ToInt32(Console.ReadLine());

//le estamos pidiendo al usuario que use este sistema que ingrese la hora de salida del vehiculo
Console.WriteLine("Hora de salida del vehiculo");

//sirve para que el usuario pueda escribir una repuesta
horaSalida = Convert.ToInt32(Console.ReadLine());

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
// el esle, en esta caso, sirve para que sino es ninguna de las anteriores, y estuvo mas de una hora pero no ocho horas, se le cobre 30 por la primera hora, y cada hora extra se le cobrara 20 mas
else
{
    int horasExtra = tiempoTotal - 1;
    PlataQueGanaraElNegocio = 30 + (horasExtra * 20);
}

// esto nos ahorra errores de logica de si por alguna razon el usuario escribe las horas al reves, ejemplo, de 9 a 7 enves de 7 a 9
if (horaSalida <= horaEntrada)
{
    Console.WriteLine("Error: La hora de salida debe ser mayor a la de entrada, escribi bien porfavor.");
    Environment.Exit(0);
}

//le decimos al usuario el total que le tiene que cobrar al vehiculo
Console.WriteLine("El total a cobrar al sujeto que dejo su vehiculo es: $" + PlataQueGanaraElNegocio);