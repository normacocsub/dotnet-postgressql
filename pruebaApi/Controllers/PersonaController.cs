using Microsoft.AspNetCore.Mvc;
using DAL;
using System;
using BLL;
using Entity;
using pruebaApi.Models;

namespace pruebaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly PersonaService _service;

        public PersonaController(PruebaContext context)
        {
            _service = new PersonaService(context);
        }

        [HttpPost]
        public ActionResult<PersonaViewModels> Guardar(PersonaInputModels personaInput)
        {
            Persona persona = MapearPersona(personaInput);
            var response = _service.Guardar(persona);
            if(response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(new PersonaViewModels(response.Object));
        }

        private Persona MapearPersona(PersonaInputModels personaInput)
        {
            var persona = new Persona()
            {
                Identificacion = personaInput.Identificacion,
                Genero = personaInput.Genero,
                Nombre = personaInput.Nombre
            };
            return persona;
        }
    }
}