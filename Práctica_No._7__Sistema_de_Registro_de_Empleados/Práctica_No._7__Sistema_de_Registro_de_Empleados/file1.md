# Documentación del proyecto

Nombre del proyecto: Práctica_No._7__Sistema_de_Registro_de_Empleados;

Elaborado por: Yuliana Martina Ramos 

Fecha de elaboración: 12 / 10 / 2026

---

### Objetivo del proyecto

Crear un programa de consola en C# que sirva para hacer un registro y análisis de un empleado, diciendo informacion y diciendo su categoria de salario.


---

### Objetivos del proyecto

1. Crear un programa de consola en C# que sirva para hacer un registro y análisis de un empleado, y que permita al usuario ingresar los datos del empleado, y que luego muestre un resumen de los datos ingresados, y que permita al usuario realizar un análisis de los datos ingresados, y que permita al usuario salir del programa cuando lo desee.
2. Empezar a utilizar la programación orientada a objetos, utilizando clases, métodos y atributos, para organizar mejor el código y para que sea más fácil de entender y de mantener, y utilizar pilares como la encapsulación.
3. Implementar validaciones para asegurar que los datos ingresados por el usuario sean correctos y completos.

---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---



### Descripción del proyecto

El programa te dara la bienvenida con un ascii bonio y te dira que ingreses:

nombre del empleado, edad, puesto, salario, y luego te dara un resumen de los datos ingresados,

y al final basado en tu salario te dira si estas en un rango de salario bajo, medio o alto 

despues te preguntara si quieres hacer otro registro o salir del programa, y si quieres hacer otro registro te pedira que ingreses los datos nuevamente, y si quieres salir del programa te dira un mensaje de despedida y se cerrara el programa.

---

### Notas del proyecto
isnullorwhitespace(); es un metodo que se utiliza para verificar si una cadena de texto es nula o esta vacia, y se utiliza en el proyecto para validar las entradas del usuario, y evitar que el programa se caiga por errores de entrada de datos.

bool: es un tipo de dato que solo puede tener dos valores, verdadero o falso, y se utiliza en el proyecto para controlar el flujo del programa y para validar las entradas del usuario.

clases: es un tipo de dato que se utiliza para crear objetos, y se utiliza en el proyecto para crear un objeto empleado, y para almacenar los datos del empleado. esto nos ayuda a organizar mejor el codigo y a que sea mas facil de entender y de mantener.

ASCII: Es una forma de dibujar con caracteres, en este caso se utilizo para dibujar un empleado trabajando con una laptop y un cafe , para que el usuario se sienta mas comodo al ver el programa y se vea mas bonito, y tambien se utilizo para dibujar una linea de separacion entre los mensajes del programa.

Console.ForegroundColor = ConsoleColor.Red/Green/Yellow: nos sirve para ponerle color a las letras, para que quede mas bonito y para que el usuario sepa si hizo algo mas o si un texto es importante

while: es una estructura de control que nos permite repetir un bloque de codigo mientras se cumpla una condicion, y se utiliza en el proyecto para permitir al usuario hacer varios registros de empleados o que vuelva a intentarlo si escribio algo incorrectamente, sin tener que reiniciar el programa .