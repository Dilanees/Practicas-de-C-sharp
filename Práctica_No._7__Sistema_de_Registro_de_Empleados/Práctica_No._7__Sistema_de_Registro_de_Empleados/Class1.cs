using System;

namespace Práctica_No._7___Sistema_de_Registro_de_Empleados;
public class Empleado

{  /*
========================================================================================
PREGUNTA DE REFLEXIÓN:
¿Por qué es conveniente utilizar atributos privados en una clase
en lugar de permitir que cualquier parte del programa los modifique
directamente?

La encapsulación nos ayuda a proteger los datos de la clase y a controlar el acceso a ellos. 
Al hacer que los atributos sean privados, nos aseguramos de que no se modifiquen por accidente 
desde fuera de la clase. Esto nos permite mantener la integridad de los datos y evitar errores 
inesperados en el programa. Solo se podrán modificar a través de métodos o propiedades (get y set), 
lo que nos permite controlar y validar exactamente qué información se guarda.
========================================================================================
*/



    //esto es un etributo que son las caracteristicas
    private string nombre_completo = "";
    private string puesto = "";
    private double horastrabajadas = 0;
    private double pagoporhora = 0;
    private double salario = 0;
    private double horasextras = 0;
    private double horas_normales = 0;


    // esto es un metodo dentro de la clase empleado que solicita los datos del empleado al usuario, que los metodos son acciones
    public void Solicitar_Datos()
    {
        nombre_completo = Leer_Texto("Ingrese el nombre completo del empleado:");
        puesto = Leer_Texto("Ingrese el puesto del empleado:");
        horastrabajadas = Leer_Entero_Positivo("Ingrese las horas trabajadas:");
        pagoporhora = Leer_Double_Positivo("Ingrese el pago por hora:");
    }



    public void Calcular_Salario()
    {
        if (horastrabajadas > 40)
        {
            horas_normales = 40;
            horasextras = horastrabajadas - 40;


        }
        else
        {
            horas_normales = horastrabajadas;
            horasextras = 0;
        }

        salario = horastrabajadas * pagoporhora * horasextras;

        double salario_normal = horas_normales * pagoporhora;
        double salario_extra = horasextras * pagoporhora * 2;

        salario = salario_normal + salario_extra;

    }

    public void Imprimir_Informacion()
    { Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("       Información del Empleado");
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("Nombre completo: " + nombre_completo);
        Console.WriteLine("Puesto: " + puesto);
        Console.WriteLine("Horas trabajadas: " + horastrabajadas);
        Console.WriteLine("Pago por hora: " + pagoporhora);
        Console.WriteLine("Salario total: " + salario);
        Console.ResetColor();
    }

    public void Categoria_Empleado()
    {

        if (salario >= 5000)
        { Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Felicitaciones, eres un empleado de salario alto!");
        }
        else if (salario >= 2000 && salario < 5000)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Muy bien, eres un empleado de salario moderado.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Eres un empleado de salario bajo :( .");
            Console.ResetColor();
        }

    }



    private string Leer_Texto(string mensaje)
    {
        Console.WriteLine(mensaje);
        string entrada = Console.ReadLine()!;
        while (string.IsNullOrWhiteSpace(entrada))
        {   Console.ForegroundColor = ConsoleColor.Red;     
            Console.WriteLine("Error: El nombre no puede estar vacío. Intente nuevamente.");
            Console.ResetColor();
            Console.WriteLine(mensaje);
            entrada = Console.ReadLine()!;





        }
        return entrada;

    }

    private double Leer_Double_Positivo(string mensaje)
    {
        Console.WriteLine(mensaje);
        string entrada = Console.ReadLine()!;
        double valor;

        while (!double.TryParse(entrada, out valor) || valor <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Debe ingresar un número positivo, no puede ingresar caracteres, signos, numeros negativos ni 0. Intente nuevamente.");
            Console.ResetColor();

            Console.WriteLine(mensaje);
            entrada = Console.ReadLine()!; // <--- Guardamos la nueva respuesta en 'entrada'
        }

        return valor;
    }
    
    private int Leer_Entero_Positivo(string mensaje)
    {
        Console.WriteLine(mensaje);
        string entrada = Console.ReadLine()!;
        int valor;



        while(!int.TryParse(entrada, out valor) || valor < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Debe ingresar un número positivo, no puede ingresar caracteres, signos ni números negativos. Intente nuevamente.");
            Console.ResetColor();
            Console.WriteLine(mensaje);
            entrada = Console.ReadLine()!;
            int.TryParse(entrada, out valor);
        }
        return valor;

    }




}
