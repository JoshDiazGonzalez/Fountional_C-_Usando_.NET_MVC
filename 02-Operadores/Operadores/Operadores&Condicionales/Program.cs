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

//if(primerNumeroString is null || primerNumeroString == "")
//{
//    Console.WriteLine("Ingreso un valor nuelo o en blanco , termino el programa");
//    return;
//}

if (string.IsNullOrEmpty(primerNumeroString))
{
    Console.WriteLine("El valor es nulo o vacio, con el operador ");
    return;
}

// Algoritmo para evaluar si un texto tiene la nomenclatura de numero
// si es posible convertir un texto a numero
// 1. Es declarar una variable resultado posible
// 2. Condicionar si el texto esta realmente escrito en una nomenclatura numerica
// 3. En caso de que no sea un numero, entonces termina el programa.
// 4. En caso de que si sea un numero entonces continua la ejecucion del programa

int primerNumeroInt = 0;

if (!int.TryParse(primerNumeroString, out primerNumeroInt))
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;
}


if(primerNumeroInt >= 100)
{
    Console.WriteLine("Su numero es mayor igual que cien");
}
else
{
    Console.WriteLine("Su numero es menor que 100");
}


if(primerNumeroInt <= 10)
{
    Console.WriteLine("Es menor igual que 10");
}
else if(primerNumeroInt > 10 && primerNumeroInt <= 20)
{
    Console.WriteLine("Es mayor que 10 y menor igual que 20");
}
else
{
    Console.WriteLine("El numero es mayor que 20");
}

//var primerNumeroInt = int.Parse(primerNumeroString!);

Console.WriteLine("Por favor ingresa el segundo numero:");
var segundoNumeroString = Console.ReadLine();
var segundoNumeroInt = int.Parse(segundoNumeroString!);


var resultadoSuma = primerNumeroInt + segundoNumeroInt;
Console.WriteLine("El resultado de la Suma es:" + resultadoSuma);


var resultadoResta = primerNumeroInt - segundoNumeroInt;
Console.WriteLine("El resultado de la Resta es:" + resultadoResta);

var resultadoMultiplicacion = primerNumeroInt * segundoNumeroInt;
Console.WriteLine($"El resultado de la Multiplicacion es {resultadoMultiplicacion}");


var resultadoDivision = primerNumeroInt / segundoNumeroInt;
Console.WriteLine($"El resultado de la Division es {resultadoDivision}");


