# Documentación del proyecto

Nombre del proyecto: Practica_No._6_Diccionario_de_Programacion_con_CRUD_y_TXT

Elaborado por: Yuliana Martina Ramos 

Fecha de elaboración: 03 / 11 / 2026

---

### Objetivo del proyecto

Crear un programa de consola en C# que Ayude a los usuarios a crear un diccionario de programación con funcionalidades de CRUD (Crear, Leer, Actualizar y Eliminar) para almacenar términos y definiciones relacionados con la programación y poder almacenarlos eliminarlos y modificarlos dentro de un archivo de texto.


---

### Objetivos del proyecto

1. crear las opciones basicas de un CRUD y utilizarlas para administrar un diccionario de programación. (crear, leer, actualizar, eliminar) y agregando de extra buscar y la opcion de salir del programa.
2. utilizar arreglos para almacenar los términos y definiciones del diccionario.
3. evitar que el usuario pueda ingresar definiciones vacías, que puede elegir otras opciones sin antes haber registrado un término, y que quiera poner numeros invalidos, caracteres, o signos en el menu principal, mostrando un mensaje de error y solicitando que intente de nuevo.
4. utilizar funciones para mas organizacion y claridad del codigo, y para evitar la repeticion de codigo.
5. utilizar un archivo de texto para guardar los términos y definiciones del diccionario, y poder cargarlos al iniciar el programa.
---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---



### Descripción del proyecto
El programa te dar ala bienvenida y te mostrara todas las opciones disponibles para administrar tu diccionario de programación. si o si tendras que elegir la opcion 1 para poder agregar un termino y su definicion, porque si intentas elegir otra opcion sin haber registrado algo primero, no te va a dejar,
una vez que hayas agregado un termino y su definicion, el programa te dejara elegir las otras opciones


las opciones de CRUD para administrar tu diccionario de programación son:

1. agregar nuevos términos(si quieres agregar mas) 
2. ver los términos existentes
3. buscar términos según su definición
4. actualizar definiciones 
5. eliminar términos según
6. salir del programa


si eliges la opcion 2 (mostrar termino) te mostrara todos los terminos que hayas agregado, 
si eliges la opcion 3 (buscar termino) te pedira que ingreses un termino y te mostrara su definicion, 
si eliges la opcion 4 (actualizar definicion) te pedira que ingreses un termino y su nueva definicion,
si eliges la opcion 5 (eliminar termino) te pedira que ingreses un termino y lo eliminara de tu diccionario,
y si eliges la opcion 6 (salir del programa) el programa se despedira amablemente y se cerrara.

Y si eres atento, te daras cuenta de que se te genera un archivo de texto llamado "diccionario.txt" en la carpeta del proyecto, que contiene todos los términos y definiciones que hayas agregado, y en el mismo programa, los cambios o modificaciones se guardarán en este archivo, puedes eliminar, actualizar o cargar los términos y definiciones en cualquier momento.

---

### Notas del proyecto
isnullorwhitespace(); es un metodo que se utiliza para verificar si una cadena de texto es nula o esta vacia, y se utiliza en el proyecto para validar las entradas del usuario, y evitar que el programa se caiga por errores de entrada de datos.

bool: es un tipo de dato que solo puede tener dos valores, verdadero o falso, y se utiliza en el proyecto para controlar el flujo del programa y para validar las entradas del usuario.

ciclo for : es una estructura de control que permite repetir un bloque de código un número determinado de veces, y se utiliza en el proyecto para recorrer los arreglos de términos y definiciones. y evitar que se cierre el programa por errores de entrada de datos o que hayan errores de logica .

i++ : es un operador que se utiliza para incrementar el valor de una variable en 1, y se utiliza en el proyecto para recorrer los arreglos de términos y definiciones.

arreglos: son estructuras de datos que permiten almacenar una colección de elementos del mismo tipo, y se utilizan en el proyecto para almacenar los términos y definiciones del diccionario de programación, y lo usamos en cada parte del crud.

Console.ForegroundColor = ConsoleColor.Red/Green/Yellow: nos sirve para ponerle color a las letras, para que quede mas bonito y para que el usuario sepa si hizo algo mas o si un texto es importante

using System.IO; es la libreria que nos permite trabajar con archivos de texto, y se utiliza en el proyecto para guardar los términos y definiciones del diccionario en un archivo de texto llamado "diccionario.txt", y para cargar los términos y definiciones desde este archivo al iniciar el programa.

archivo.txt: es un archivo de texto que se utiliza para guardar los términos y definiciones del diccionario de programación, y se genera automáticamente en la carpeta del proyecto cuando se ejecuta el programa por primera vez. igual en este caso lo llame diccionario.txt ya que es el contexto de un diccionario de programación.