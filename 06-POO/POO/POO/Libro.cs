
namespace POO
{
    public class Libro
    {
        private string _nombre;
        protected string _autor;
        private int _cantidadPaginas;

      
        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

        public string GetDescripcion()
        {
            return $"{_nombre} por {_autor}, cantidad {_cantidadPaginas}";
        }

        public string GetNombre()
        {
            return _nombre; 
        }

        public void SetNombre(string nombreLibro)
        {
            _nombre = nombreLibro;
        }

        public string GetAutor()
        {
            return _autor;
        }

        public void SetAutor(string autorNuevo)
        {
            _autor = autorNuevo;
        }

        public int GetCantidadPaginas() { 
            return _cantidadPaginas;
        }

        public void SetCantidadPaginas(int nuevaCantidadPAginas) 
        {
            _cantidadPaginas = nuevaCantidadPAginas;
        }


    }
}
