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
    public class ReferenciasPersonalesController : ControllerBase
    {
        public List<ReferenciasPersonales> ListaReferenciasPersonales { get; set; }

        public ReferenciasPersonalesController()
        {
            ListaReferenciasPersonales = new List<ReferenciasPersonales>();
            ReferenciasPersonales referenciasPersonales = new ReferenciasPersonales()
            {
                Nombre = "Kaligula",
                Ocupacion = "Gamers",
                TelefonoDeContacto = "35050052pito",
                Email = "shido1497@gmail.com",
                Relacion = "Primo",
                IdPersona = Guid.NewGuid()
            };
            ListaReferenciasPersonales.Add(referenciasPersonales);
            ListaReferenciasPersonales.Add(new ReferenciasPersonales()
            {
                Nombre = "Kaligula",
                Ocupacion = "Gamers",
                TelefonoDeContacto = "35050052pito",
                Email = "shido1497@gmail.com",
                Relacion = "Primo",
                IdPersona = Guid.NewGuid()
            }
                );
            ListaReferenciasPersonales.Add(referenciasPersonales);
            referenciasPersonales.Nombre = "Julian";
        }

        [HttpGet]
        public List<ReferenciasPersonales> Get ()
        {
            return ListaReferenciasPersonales;
        }

        [HttpPost]
        public List<ReferenciasPersonales> Post([FromBody] ReferenciasPersonales referenciasPersonales)
        {
            ListaReferenciasPersonales.Add(referenciasPersonales);
            return ListaReferenciasPersonales;
        }
    }

}
