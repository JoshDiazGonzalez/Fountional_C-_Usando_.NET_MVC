using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Publicacion
    {
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int NumeroPaginas { get; set; }


        public Publicacion(string nombre, decimal precio, int numeroPaginas)
        {
            Nombre = nombre;
            Precio = precio;
            NumeroPaginas = numeroPaginas;
        }

        public virtual string GetDescripcion() => $"{Nombre} precio {Precio}";
    }
}
