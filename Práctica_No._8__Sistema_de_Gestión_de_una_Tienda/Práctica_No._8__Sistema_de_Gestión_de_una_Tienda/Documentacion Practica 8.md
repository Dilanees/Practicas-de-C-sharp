# Documentación del proyecto

Nombre del proyecto: Práctica_No._8__Sistema_de_Gestión_de_una_Tienda

Elaborado por: Yuliana Martina Ramos 

Fecha de elaboración: 03 / 11 / 2026

---

### Objetivo del proyecto

Crear un programa de consola en C# que sirva para hacer un registro y análisis de un empleado, diciendo informacion y diciendo su categoria de salario.


---

### Objetivos del proyecto

1. Crear un programa de consola en C# que sirva para hacer un registro y análisis de un empleado, diciendo informacion y diciendo su categoria de salario.
2. separar la informacion del cliente y del producto en clases diferentes para que el programa sea mas organizado y facil de entender.
3. conectar todas las clases con la clase venta para que el programa pueda funcionar correctamente y mostrar el ticket de venta con toda la informacion del cliente y del producto.
4. crear un bucle para que el programa pueda hacer varias gestiones o escribir correctamente una casilla de la tienda sin tener que reiniciar el programa cada vez que se quiera hacer una nueva gestion o cada vez que escribimos incorrectamente. 
4. Implementar validaciones para asegurar que los datos ingresados por el usuario sean correctos y completos.



---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---



### Descripción del proyecto

El programa te dara la bienvenida y te dira que ingreses:

eso relacionado a cliente
nombre, correo, telefono


eso relacionado a producto
nombre, precio, cantidad

despues de eso te mostrara el ticket de venta , con el nombre del cliente, correo, telefono, nombre del producto, precio, cantidad, subtotal y total a pagar.

despues te preguntara si quieres hacer otro registro o salir del programa, y si quieres hacer otra gestion de la tienda tienes que apretar la teclas "ENTER" y si quieres salir del programa tienes que ecribir "SALIR" para que te de un mensaje de despedida y se cerrara el programa.



---

### Notas del proyecto
isnullorwhitespace(); es un metodo que se utiliza para verificar si una cadena de texto es nula o esta vacia, y se utiliza en el proyecto para validar las entradas del usuario, y evitar que el programa se caiga por errores de entrada de datos.

bool: es un tipo de dato que solo puede tener dos valores, verdadero o falso, y se utiliza en el proyecto para controlar el flujo del programa y para validar las entradas del usuario.

clases: es un tipo de dato que se utiliza para crear objetos, en este caso se utilizan para crear objetos de cliente, producto y venta, y se utilizan en el proyecto para organizar el codigo y para que sea mas facil de entender.

return: la palabra clave return se utiliza para devolver un valor desde un metodo, y se utiliza en el proyecto para devolver valores desde los metodos de las clases.

Console.ForegroundColor = ConsoleColor.Red/Green/Yellow/Magenta: nos sirve para ponerle color a las letras, para que quede mas bonito y para que el usuario sepa si hizo algo mas o si un texto es importante