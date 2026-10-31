# Documentación del proyecto

Nombre del proyecto: Práctica No. 3: Sistema de ventas de una tienda pequeña
Elaborado por: Yuliana Martina Ramos

Fecha de elaboración: 19 / 09 / 2026

---

### Objetivo del proyecto
---

Desarrollar una aplicación de consola en C# que funcione como un sistema de caja registradora ("SmallStore"), permitiendo ingresar dinámicamente el número de ventas del día, registrar los montos correspondientes a cada transacción, validar que los datos sean numéricos y positivos, y finalmente calcular los totales, promedios y métricas de desempeño.

---

### Objetivos del proyecto

1. Aprender a calcular el total acumulado de dinero ganado en el día y el promedio por transacción a partir de las ventas ingresadas.

2. Poder analizar los datos comparando cada venta individual contra el promedio para saber cuántas transacciones superaron esa media diaria.

3. Saber cómo evitar errores de entrada de datos por parte del usuario, impidiendo que el programa colapse al ingresar letras, caracteres especiales, números negativos o ceros.

4. Hacer un bucle while para que el usuario tenga que volver a ingresar un monto correcto si se equivoca, y también para que pueda registrar un nuevo día de ventas sin tener que reiniciar el programa.

---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---

### Descripción del proyecto

primero el programa le da la bienvenida al usuario
y le Pregunta al usuario la cantidad de ventas totales realizadas durante el día.

En base al número ingresado, solicita al usuario cuanto dinero han obtenido en cada una de las ventas individuales.

y al final 
el programa Mostrara los resultados financieros
que serian
Total de ventas de hoy:
promedio de ventas de hoy:
ventas mayores al promedio:

y brinda la opción de reiniciar para volver al inicio para registrar un nuevo registro de ventas o poder escribir el comando "salir" para finalizar el programa.

---

### Notas del proyecto

Ahora le puse un bucle while 

ya que si el usuario ponia de menera erronea alguna casilla o si te mostraba el total, el programa se cerraba y no le daba la oportunidad de volver a ingresar las ventas correctamente o volver a poner nuevas ventas y valores de las ventas,
ahora el programa le dara la oportunidad de volver a ingresar los horarios correctos hasta que lo haga correctamente. 

y tambien ahora el programa no te dejara escribir numeros negativos, signos como el "+" o caracteres especiales ,no te dejara poner 0,


Console.ForegroundColor = ConsoleColor.Red/Green/Yellow: nos sirve para ponerle color a las letras, para que quede mas bonito y para que el usuario sepa si hizo algo mas o si un texto es importante


TryParse: usamos tryparse para convertir texto en numeros y que si no podes algo bien el programa no explote o se crashee