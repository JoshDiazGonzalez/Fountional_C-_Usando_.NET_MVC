
var mensaje = GetMensajePorEdad(25);

Console.WriteLine(mensaje);

string GetMensajePorEdad(int edad)
{
    if (edad > 18)
    {
        return "Es mayor de edad";
    }
    else
    {
        return "Es menor de edad";
    }

}