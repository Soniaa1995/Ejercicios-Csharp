using System;

namespace Concesionario
{
    class Coche
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Combustible { get; set; }
        public int Kilometros { get; set; }

        public Coche(string matricula, string marca, string modelo, string combustible, int kilometros)
        {
            this.Matricula = matricula;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Combustible = combustible;
            this.Kilometros = kilometros;
        }

        public override string ToString()
        {
            return Matricula.PadRight(20) +
                Marca.PadRight(20) +
                Modelo.PadRight(20) +
                Combustible.PadRight(20) +
                Kilometros;
        }
    }
}
