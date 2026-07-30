using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Revista : Publicacion
    {
        public string? Periodista { get; set; }

        public Revista(string? periodista, string nombre, int cantidadPaginas, decimal precio)
            : base(nombre, precio, cantidadPaginas)
        {
            Periodista = periodista;
        }

        public override string GetDescripcion()
            => $"Revista {Nombre} escrito por {Periodista}, paginas {NumeroPaginas}";
    }
}
