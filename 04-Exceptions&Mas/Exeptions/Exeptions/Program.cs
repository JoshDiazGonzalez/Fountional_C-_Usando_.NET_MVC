// 1. El usuario ingresa n veces numeros a sumarse
// 2. Si el usuario ingresa un numero = 0 entonces se debe detener la suma
// 3. Imprime el total de la suma, de los numeros ingresados

int acumulador = 0;
int numero  = 0;

do
{
    Console.WriteLine("Ingrese el numero a sumar:");
    try
    {
        numero = int.Parse(Console.ReadLine()!);
    }
    catch (System.FormatException e)
    {
        Console.WriteLine($"El error tiene este detalle : {e.Message}");
        if(e.Message is null)
        {
            throw;
        }
        continue;
    }
    
    acumulador += numero;
} while (numero != 0);

Console.WriteLine($"El total de la suma es: {acumulador}");