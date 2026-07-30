// objetivo: Registrar un nuevo producto en una tienda
// 1. El usuario ingresa la data del producto como: nombre, precio, stock
// 2. El programa va a capturar la data y procedera a poner un precio de venta
// que incluya el costo del impuesto del producto
// 3. El metodo de registro de producto debe devolver la data del producto
// 4. El programa debe imprimir la data del producto registrado


Console.WriteLine("Ingrese el nombre del producto");
var nombreProducto = Console.ReadLine();

Console.WriteLine("Ingrese el precio del producto");
var precioProducto = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ingrese el stock del producto");
var stockProducto = int.Parse(Console.ReadLine()!);

(double, int, string) GetProducto(string nombreProducto, int precioProducto, int stock)
{
    var precioFinal = precioProducto + precioProducto * 0.2;

    return (precioFinal, stock, nombreProducto);
}


var tupla = GetProducto(nombreProducto!, precioProducto, stockProducto);

Console.WriteLine($"Datos del producto {tupla.Item3} \n Precio Final: {tupla.Item1} \n Stock: {tupla.Item2}");



