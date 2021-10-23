using System;
using Entity;
namespace pruebaApi.Models
{
    public class PersonaInputModels
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
    }

    public class PersonaViewModels : PersonaInputModels
    {
        public PersonaViewModels(Persona persona)
        {
            Identificacion = persona.Identificacion;
            Nombre = persona.Nombre;
            Genero = persona.Genero;
        }
    }
}