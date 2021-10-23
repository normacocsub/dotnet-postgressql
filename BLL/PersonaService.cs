using System;
using DAL;
using Entity;
namespace BLL
{
    public class PersonaService
    {
        private readonly PruebaContext _context;

        public PersonaService(PruebaContext context)
        {
            _context = context;
        }

        public ResponseClass<Persona> Guardar(Persona persona)
        {
            try
            {
                _context.Personas.Add(persona);
                _context.SaveChanges();
                return new ResponseClass<Persona>(persona);
            }
            catch(Exception e)
            {
                return new ResponseClass<Persona>($"Error en la aplicacion {e.Message}");
            }
        }
    }
}