//Calcular el salario de un empleado

int salarioTotal = 0;
CalcularSalarioTotal(salario:1000, impuesto:500, salud:100, out salarioTotal);
Console.WriteLine($"El salario total es: {salarioTotal}");


void CalcularSalarioTotal(int salario, int impuesto, int salud, out int total)
{
    total = salario - impuesto - salud;
}