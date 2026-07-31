// Crear Queue Collection

Queue<string> miQueue = new Queue<string>();

// agregar elementos
miQueue.Enqueue("uno");
miQueue.Enqueue("dos");
miQueue.Enqueue("tres");
miQueue.Enqueue("cuatro");
miQueue.Enqueue("cinco");
miQueue.Enqueue("seis");

// utilizando un foreach

foreach (string s in miQueue)
{
    Console.WriteLine(s);
}

// Buscar al primer elemento del queue

var miPrimerElemento = miQueue.Peek();
Console.WriteLine($"Mi Primer elemento es: {miPrimerElemento}");

// Eliminar un elemento de un queue
string elementoParaEliminar = miQueue.Dequeue();
Console.WriteLine($"Se elimino el elemento: {elementoParaEliminar}");
foreach (string s in miQueue)
{
    Console.WriteLine(s);
}

// Utilizamos el contains para saber si ese elemento existe
var existeElemento = miQueue.Contains("tres");
Console.WriteLine($"Existe el elemento tres en la coleccion?: {existeElemento}");