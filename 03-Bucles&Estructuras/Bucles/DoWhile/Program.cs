/*
 * 1. El usuario ingrsa n veces numeros a sumarse
 * 2. Si el usuario ingresa un numeor = 0 entonces se debe detener la suma
 * 3. Imprime el total de la suma, de los numeros ingresados
*/

int numero = 0;
int acumulador = 0;

do
{
    Console.WriteLine("Ingrese el numero");
    numero = int.Parse(Console.ReadLine()!);
    acumulador += numero;
} while (numero != 0);

Console.WriteLine($"La suma total = {acumulador}");