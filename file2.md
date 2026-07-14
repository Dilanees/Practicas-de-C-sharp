# Documentación del proyecto

Nombre del proyecto: Práctica No. 1: Cálculo de cobro en un estacionamiento

Elaborado por: Yuliana Martina Ramos

Fecha de elaboración: 13 / 07 / 2026

---

### Objetivo del proyecto

Crear un programa de consola en C# que automatize el cobro de vehiculos de un estacionamiento, calculando el tiempo de permanencia y el costo total de cobrarle al vehiculo 

---

### Objetivos del proyecto

1. Aprender a calcular el tiempo de permanencia y el costo total a pagar por el usuario, considerando las tarifas establecidas
2. Poder aplicar las reglas de cobro dependiendo de las horas de permanencia del vehículo en el estacionamiento 
3. Saber como evitar errores de entrada de datos por parte del usuario, como ingresar letras o caracteres especiales en lugar de números.

---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---

### Descripción del proyecto

EL sistema se presenta al usuario con un mensaje de bienvenida y le solicita que ingrese el horario de entrada y salida del vehiculo del estacionamiento
y el sistema empieza a calcula el costo total a pagar por el usuario, considerando que:

 La primera hora cuesta $30.  
 Cada hora adicional cuesta $20.  
Si el vehículo permanece más de 8 horas, se aplica una tarifa fija de $180 por todo el día.  
Si el tiempo fue menor a 1 hora, se cobra como 1 hora completa. 

si el usuario ingresa un horario de salida menor al de entrada, se le mostrara un mensaje de error y se cerrara el programa
y el usuario tendra que volver a ejecutar el programa para poder ingresar los horarios correctos.



---

### Notas del proyecto

Convert.ToInt32(Console.ReadLine()): lo utilizamos para convertir la entrada del usuario (que es un string) a un número entero, para que el programa pueda restarlo 
Formula de horas extras: (horaSalida - horaEntrada) - 1: Esta fórmula calcula las horas adicionales que el vehículo ha permanecido en el estacionamiento, restando la primera hora ya cobrada
Environment.Exit(0): Sirve para finalizar el programa de manera inmediata, sin importar en qué parte del código se encuentre