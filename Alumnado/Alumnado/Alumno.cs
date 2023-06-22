using System;


namespace Alumnado
{
    class Alumno
    {
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
            return Nombre.PadRight(15) + Apellidos.PadRight(30) + Edad.PadRight(10) + Nota;
        }
    }
}
