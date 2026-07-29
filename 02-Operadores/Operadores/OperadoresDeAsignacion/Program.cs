/*
 * Este algoritmo se encarga de realizar las operaciones basicas
 * matematicas de dos numeros:
 * 
 * 1. El cliente ingrese un numero x
 * 2. El cliente ingresa un segundo numero y
 * 3. El programa captura estos valores y los almacenas en variables
 * 4. El programa se encarga de realizar la operacion matematica
 * 5. El programa se encarga de imprimir el resutlado de la operacion
 */

Console.WriteLine("Por favor ingresa su primer numero:");
var primerNumeroString = Console.ReadLine();
var primerNumeroInt = int.Parse(primerNumeroString!);

Console.WriteLine("Por favor ingresa el segundo numero:");
var segundoNumeroString = Console.ReadLine();
var segundoNumeroInt = int.Parse(segundoNumeroString!);


//var resultadoSuma = primerNumeroInt + segundoNumeroInt;
var resultadoSuma = primerNumeroInt;
resultadoSuma += segundoNumeroInt;
Console.WriteLine("El resultado de la Suma es:" + resultadoSuma);


//var resultadoResta = primerNumeroInt - segundoNumeroInt;
var resultadoResta = primerNumeroInt;
resultadoResta -= segundoNumeroInt;
Console.WriteLine("El resultado de la Resta es:" + resultadoResta);

//var resultadoMultiplicacion = primerNumeroInt * segundoNumeroInt;
var resultadoMultiplicacion = primerNumeroInt;
resultadoMultiplicacion *= segundoNumeroInt;
Console.WriteLine($"El resultado de la Multiplicacion es {resultadoMultiplicacion}");


//var resultadoDivision = primerNumeroInt / segundoNumeroInt;
var resultadoDivision = primerNumeroInt;
resultadoDivision /= segundoNumeroInt;
Console.WriteLine($"El resultado de la Division es {resultadoDivision}");


