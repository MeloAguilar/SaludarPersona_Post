using System;

namespace SaludarPersona_Post_Entities
{
    public class clsPersona
    {
        private string nombre;
        private string apellidos;

        public string Nombre{ get; set; }
        public string Apellidos { get; set; }

        public clsPersona(string _nombre, string _apellidos)
        {
            this.Nombre = _nombre;
            this.Apellidos = _apellidos;
        }
    }
}
