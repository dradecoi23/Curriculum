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
    public class EstudiosRealizadosController : ControllerBase
    {
        public List<EstudiosRealizados> listaEstudios { get; set; }

        public EstudiosRealizadosController()
        {
            listaEstudios = new List<EstudiosRealizados>();
            EstudiosRealizados estudiosRealizados = new EstudiosRealizados()
            {
                NombreEstudio = "Usurpador del trono",
                TipoEstudio = "Profesional",
                InstitucionEducativa = "La calle",
                TiempoCursado = "Toda la vida ñero"
            };
            listaEstudios.Add(estudiosRealizados);
            listaEstudios.Add(new EstudiosRealizados()
            {
                NombreEstudio = "CHABOT",
                TipoEstudio = "Alo legal",
                InstitucionEducativa = "La calle",
                TiempoCursado = "Super F"
            });

        }
        //Metodo
        [HttpGet]
        public IEnumerable<EstudiosRealizados> Get()
        {
            return listaEstudios;
        }

        //Metodo
        [HttpPost]
        public IActionResult Post([FromBody] EstudiosRealizados datos)
        {
            listaEstudios.Add(datos);
            return Ok(listaEstudios);
        }
    }
}
