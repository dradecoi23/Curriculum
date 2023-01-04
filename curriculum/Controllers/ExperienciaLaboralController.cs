using Curriculum.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curriculum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienciaLaboralController : ControllerBase
    {
        public List<ExperienciaLaboral> listaExperienciaLaboral { get; set; }
        public ExperienciaLaboralController()
        
        {
            listaExperienciaLaboral = new List<ExperienciaLaboral>();
            ExperienciaLaboral experienciaLaboral = new ExperienciaLaboral()
            {
                IdUsuario = Guid.NewGuid(),
                NombreEmpresa = "Microsoft",
                Cargo = "Putazo",
                FechaInicial = new DateTime(2010, 2, 1),
                FechaFinal = new DateTime(2015, 12, 1),
                DescripcionCargo = "Repartir nalga",
                JefeInmediato = "Ronaldinho",
                TelefonoContacto = "1234567"
            };
            listaExperienciaLaboral.Add(experienciaLaboral);
            listaExperienciaLaboral.Add(new ExperienciaLaboral()
            {
                IdUsuario = Guid.NewGuid(),
                NombreEmpresa = "Google",
                Cargo = "Trolazo",
                FechaInicial = new DateTime(2015, 2, 1),
                FechaFinal = new DateTime(2017, 12, 1),
                DescripcionCargo = "Repartir chimbo",
                JefeInmediato = "Cristiano Ronaldo",
                TelefonoContacto = "8912345"
            });
        }
        //metodo}
        [HttpGet]
        public IEnumerable<ExperienciaLaboral> Get()
        {
            return listaExperienciaLaboral;
        }
        //metodo
        [HttpPost]
        public IActionResult Post([FromBody] ExperienciaLaboral datos)
        {
            listaExperienciaLaboral.Add(datos);
            return Ok(listaExperienciaLaboral);
        }
    }
}
