using System;

namespace Gestion_de_alumnos
{
    internal class Alumno
    {
        private string nombre;
        private string apellidos;
        private string edad;
        private float nota;


        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public float Nota { get; set; }


        public Alumno(string nombre, string apellidos, string edad, float nota)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Nota = nota;
        }

        public override string ToString()
        {
            return Nombre.ToString() + 
                Apellidos.ToString() + 
                Edad.ToString() + 
                Nota.ToString();
        }
    }
}
