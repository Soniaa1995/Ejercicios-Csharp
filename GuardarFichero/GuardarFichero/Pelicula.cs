using System;
using System.Security.Cryptography.X509Certificates;

namespace GuardarFichero
{
    class Pelicula
    {
        private string nombre;
        private string genero;
        private string director;
        private string actores;
        private string anyo;


        public Pelicula(string nombre, string genero, string director, string actores, string anyo)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.director = director;
            this.actores = actores;
            this.anyo = anyo;  
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Director { get => director; set => director = value; }
        public string Actores { get => actores; set => actores = value; }
        public string Anyo { get => anyo; set => anyo = value; }


        public override string ToString()
        {
            return nombre.PadRight(30) +
               genero.PadRight(20) +
               director.PadRight(20) +
               actores.PadRight(20) +
               anyo;
        }
    }
}
