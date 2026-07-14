﻿
# Documentación del proyecto

Nombre del proyecto: Práctica No. 2: Adivina el número

Elaborado por: Yuliana Martina Ramos

Fecha de elaboración: 13 / 07 / 2026

---

### Objetivo del proyecto

Crear un programa en C# que sea como un juego interactivo de estilo frio calor, haciendo que el usuario tenga 5 intentos para
tratar de adivinar un numero aleatorio que fue generado por el programa, y que el programa le indique al usuario si su intento fue frio o caliente, dependiendo de la cercanía del número ingresado con el número aleatorio generado

---

### Objetivos del proyecto

1. Aprender a utilizar la clase Random para generar números aleatorios en C#.
2. Crear un juego que se repita hasta que el usuario adivine el número o se le acaben los intentos 
3. Saber como evitar errores de entrada de datos por parte del usuario, como ingresar letras o caracteres especiales en lugar de números.

---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---

### Descripción del proyecto

se creo un programa tipo videojuego de consola interactivo llamado "Adivina el número". Al iniciar, 
el programa solicita el nombre del usuario y le explica las reglas y las pistas (Muy Frío, Frío, Tibio, Caliente, Muy Caliente).
despuies, el sistema genera de forma interna un número aleatorio entre 1 y 100. El usuario introduce sus 
respuestas y el programa evalúa la cercania del numero puesto por el usuario y el numero generado. Si el usuario adivina, el juego lo felicita
y finaliza inmediatamente. Si se agotan los 5 intentos, el sistema le avisa al usuario que perdio y le revelara el numero secreto.

---

### Notas del proyecto

Random: Se utiliza para generar (en este caso numeros) aleatorios
.Next(1, 101): se utiliza para en este caso dar un limite minimo (1) y maximo (101)
Math.Abs() : Se utiliza para obtener el valor absoluto de un numero, en este caso para calcular la diferencia entre el numero ingresado por el usuario y el numero aleatorio generado por el sistema
Console.ReadLine()! : se utiliza para leer la entrada del usuario y el signo de exclamación (!) se utiliza para indicar que la entrada no es nula, es decir que el usuario ingresara un valor y no dejara el espacio en blanco
continue: se utiliza para (en este caso) que el programa no se detenga y siga ejecutandose hasta que el usuario adivine el numero o se le acaben los intentos
break: utilizado para salir del bucle cuando el usuario adivina el numero secreto
bool ganaste : se utiliza para indicar si el usuario gano o perdio, en este caso comienza en falso y si el usuario adivina el numero secreto se cambia a verdadero
