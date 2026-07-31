// Crear un diccionario
Dictionary<string, string> miDiccionario = new Dictionary<string, string>();

// Agregar elementos a un diccionario
miDiccionario.Add(".doc", "Documentos de Word");
miDiccionario.Add(".txt", "Block de Notas");
miDiccionario.Add(".html", "Paginas Web");
miDiccionario.Add(".jpg", "Archivos de Imagen");

// intentando agregar un elemento con un key repetido
// miDiccionario.Add(".doc", "Otro documento word");
var sePuedeAgregarElemento = miDiccionario.TryAdd(".doc", "Otro intento word");
if (!sePuedeAgregarElemento)
{
    Console.WriteLine("No se pudo insertar elemento por que es key duplicado");
}

// Actualizar el valor de un dictionary element
miDiccionario[".txt"] = "Este es el nuevo valor de documento .TXT";


//Buscar elementos de un dictionary por el key y por el valor
Console.WriteLine($"Buscando un key bmp: {miDiccionario.ContainsKey(".jpg")} ");
Console.WriteLine($"Buscando un value html: {miDiccionario.ContainsValue("Paginas Web")} ");


// Eliminar un elemento de un dictionary
miDiccionario.Remove(".jpg");


//Acceder a un elemento del dictionary
var valorHtml = miDiccionario[".html"];
Console.WriteLine($"El valor de la key .html es: {valorHtml}");




// Imprimir elementos del dictionary

foreach (KeyValuePair<string, string> elemento in miDiccionario)
{
    Console.WriteLine($"Imprime el elemento: {elemento.Key} - {elemento.Value}");
}



