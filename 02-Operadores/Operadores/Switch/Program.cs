Console.WriteLine("Por favor ingrese su primer numero:");
var primerNumeroString = Console.ReadLine();

//if (primerNumeroString is null || primerNumeroString == "")
//{
//    Console.WriteLine("Ingreso un valor nulo o en blanco, termino el programa");
//    return;
//}

if (string.IsNullOrEmpty(primerNumeroString))
{
    Console.WriteLine("El valor es nulo o vacio, con el operador isNullOrEmpty");
    return;
}

int primerNumeroInt = 0;

if (!int.TryParse(primerNumeroString, out primerNumeroInt))
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;
}

if (primerNumeroInt >= 100)
{
    Console.WriteLine("Su numero es mayor igual que cien");
}
else
{
    Console.WriteLine("Su numero es menor que 100");
}

if (primerNumeroInt <= 10)
{
    Console.WriteLine("Es menor igual que 10");
}
else if (primerNumeroInt > 10 && primerNumeroInt <= 20)
{
    Console.WriteLine("Es mayor que 10 y menor igual que 20");
}
else
{
    Console.WriteLine("El numero es mayor que 20");
}

Console.Write("Por favor ingrese el segundo numero:");
var segundoNumeroString = Console.ReadLine();

if (string.IsNullOrEmpty(segundoNumeroString))
{
    Console.WriteLine("El segundo numero esta en blanco o nulo");
    return;
}

var segundoNumeroInt = 0;

if (!int.TryParse(segundoNumeroString, out segundoNumeroInt))
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;
}

Console.WriteLine("Selecciona: 1) Suma, 2) Resta, 3) Multiplicacion, 4) Division");
int tipoOperacion = int.TryParse(Console.ReadLine(), out tipoOperacion) ? tipoOperacion : 0;


var total = 0;
switch (tipoOperacion)
{
    case 1:
        total = primerNumeroInt + segundoNumeroInt;
        Console.WriteLine($"{primerNumeroInt}  + {segundoNumeroInt} = {total}");
        break;

    case 2:
        total = primerNumeroInt - segundoNumeroInt;
        Console.WriteLine($"{primerNumeroInt} - {segundoNumeroInt} = {total} ");
        break;

    case 3:
        total = primerNumeroInt * segundoNumeroInt;
        Console.WriteLine($"{primerNumeroInt} x {segundoNumeroInt} = {total}");
        break;

    case 4:
        total = primerNumeroInt / segundoNumeroInt;
        Console.WriteLine($"{primerNumeroInt} / {segundoNumeroInt} = {total}");
        break;

    default:
        Console.WriteLine("Ingreso un valor erroneo, debe ingresar un numero del 1 al 4");
        return;

}

