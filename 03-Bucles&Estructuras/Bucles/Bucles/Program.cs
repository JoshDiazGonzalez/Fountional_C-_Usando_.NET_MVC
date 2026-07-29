//Bucle para imprimir 88 veces el texto BIenvenido al curso de c#

for (int i = 1; i <= 88; i+=5)
{
    Console.WriteLine("Bienvenido al curso de C# Avanzado");
}

/*
 * 1. El Usuario ingresa un numero en la consola
 * 2. El programa multiplica por los primeros 10 numeros a este numero ingresado
 * 3. Se debe imprimir el resultado de cada operacion
 */

Console.WriteLine("Ingrese un a multiplicar 10 veces");
var numeroParaMultiplicar = int.Parse(Console.ReadLine()!);

for (int i = 1; i<=10; i++)
{
    int resultado = i * numeroParaMultiplicar;
    Console.WriteLine($"{i} x {numeroParaMultiplicar} = {resultado}");
}