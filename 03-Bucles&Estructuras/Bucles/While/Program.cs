/*
 * 1. El usuario ingresa un numeor 
 * 2. El programa captura el numero e imprime una lista de numero superiores
 * hasta el maximo de 100
 * regla: el numero ingresado por el usuario no debe ser mayor o igual que 100
*/

using System.Collections.Concurrent;

Console.WriteLine("Ingrese un numero menor que 100");
int numero = int.Parse(Console.ReadLine()!);

while(numero <= 100)
{
    Console.WriteLine(numero);
    numero++;
}