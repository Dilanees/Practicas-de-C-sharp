# Documentación del proyecto

Nombre del proyecto: Práctica_No._4_Registro_de_temperaturas_semanales

Elaborado por: Yuliana Martina Ramos

Fecha de elaboración: 19 / 10 / 2026

---

### Objetivo del proyecto

Desarrollar un programa de consola en C# que funcione como un asistente interactivo ("Terperito") 
para registrar las temperaturas de los 7 días de la semana, validar los ingresos numéricos del usuario, 
calcular datos estadísticos (máxima, mínima, acumulado total, promedio semanal y días por encima o debajo
del promedio) y permitir la ejecución continua mediante un bucle interactivo.

---

### Objetivos del proyecto
1. Poder calcular valores estadísticos a partir de los datos ingresados, 
   como obtener la suma total, calcular el promedio, y encontrar la temperatura máxima y mínima.

2. Aprender a utilizar arreglos (arrays) y ciclos (for, foreach) para almacenar y procesar múltiples
    datos de forma ordenada (en este caso, las 7 temperaturas de la semana).

3. Saber cómo evitar errores de entrada de datos por parte del usuario, 
usando ciclos if, bucles while e incluso un tryparse, para evitar colapsos en el programa

4. Hacer un bucle while para que el usuario, en caso de equivocarse, deba volver a ingresar el dato correctamente, 
y también para que pueda registrar otra semana completa de temperaturas sin tener que reiniciar el programa.

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---

### Descripción del proyecto

EL sistema se presenta al usuario con un mensaje de bienvenida y le solicita al usuario que ingrese la temperatuira de los 7 dias de la semana
(desde el dia 1, hasta el dia 7)

Despues de que ingrese las temperaturas correctamente
el programa calculara:
Temperatura mas alta
Temperatura mas baja
Suma total
Promedio semanal
Temperaturas mayores al promedio
Temperaturas menores al promedio
y le mostrara los resultados al usuario

por ultimo se le dara la opcion de continuar o salir, si quiere continuar tiene que apretar la tecla "ENTER" 
y el programa se reiniciara, si no quiere tendra que escribir "salir" y el programa se cerrara.




### Notas del proyecto



bucle while: para evitar que cuando  el usuario ingrese algo erroneo o al mostrar el total, el programa se cierre y no te de la oportunidad de volver a ingresar las temperatutras correctamente o volver a resgistrar mas temperaturas semanales,
ahora el programa le dara la oportunidad de volver a ingresar los horarios correctos hasta que lo haga correctamente. 

Console.ForegroundColor = ConsoleColor.Red/Green/Yellow: nos sirve para ponerle color a las letras, para que quede mas bonito y para que el usuario sepa si hizo algo mas o si un texto es importante

Correcion de errores: Habia accidentalmente dividido el resultado total en 7, entonces terminaba dando un resultado decimal, y tambien habia sumado dos veces los resultados finales

Uso de arreglos (arrays): En lugar de crear 7 variables distintas (una para cada día), 
usamos un arreglo que funciona como una sola lista con 7 casilleros.
esto nos permite guardar todas las temperaturas juntas en un mismo lugar. Ademas nos facilita la tarea de calcular los totales finales y que se guarde todo