using Microsoft.SqlServer.Server;
using System;
using System.IO;


namespace libreria
{
    class Libro
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public string AnyoPublicacion { get; set; }

        public Libro(string nombre, string genero, string autor, string anyoPublicacion)
        {
            this.Nombre = nombre;
            this.Genero = genero;
            this.Autor = autor;
            this.AnyoPublicacion = anyoPublicacion;
        }

        public override string ToString()
        {
            return Nombre.PadRight(30) + 
                Genero.PadRight(20) +
                Autor.PadRight(20) +
                AnyoPublicacion;
        }
    }
}
