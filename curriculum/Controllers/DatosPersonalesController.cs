using Curriculum.Dto;
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
    public class DatosPersonalesController : ControllerBase
    {
        public List<DatosPersonales> listaDatos { get; set; }
        
        public DatosPersonalesController()
        {
            listaDatos = new List<DatosPersonales>();
            DatosPersonales datosPersonales = new DatosPersonales()
            {

                Nombres = "German David",
                Apellidos = "Franco Herrera",
                TipoDocumento = "Cedula",
                Nacionalidad = "Colombiana",
                NumeroDocumento = "1020453213",
                FechaNacimiento = new DateTime(1993, 4, 23),
                Sexo = "Masculina",
                Email = "gonorrzssientos@gmail.com",
                Profesion = "Mariguanoprofesional",
                TelefonoFijo = "55555555",
                TelefonoMovil = "3218782519",
                DescripcionPerfil = "Hola trabajo mucho y llevo mucho tiempo"
            };
            listaDatos.Add(datosPersonales);
            listaDatos.Add(new DatosPersonales()
            {

                Nombres = "German David",
                Apellidos = "Franco Herrera",
                TipoDocumento = "Cedula",
                Nacionalidad = "Colombiana",
                NumeroDocumento = "1020453213",
                FechaNacimiento = new DateTime(1993, 4, 23),
                Sexo = "Masculina",
                Email = "gonorrientos@gmail.com",
                Profesion = "Mariguanoprofesional",
                TelefonoFijo = "55555555",
                TelefonoMovil = "3218782519",
                DescripcionPerfil = "Hola trabajo mucho y llevo mucho tiempo"
            });

        }

        //Metodo
        [HttpGet]
        public IEnumerable<DatosPersonales> Get()
        {
            return listaDatos;
        }

        //Metodo
        [HttpPost]
        public IActionResult Post([FromBody] DatosPersonalesDto datos)
        {
            listaDatos.Add(new DatosPersonales()
            {

                Nombres = datos.Nombres,
                Apellidos = datos.Apellidos,
                TipoDocumento = datos.TipoDocumento,
                Nacionalidad = datos.Nacionalidad,
                NumeroDocumento = datos.NumeroDocumento,
                FechaNacimiento = datos.FechaNacimiento,
                Sexo = datos.Sexo,
                Email = datos.Email,
                Profesion = datos.Profesion,
                TelefonoFijo = datos.TelefonoFijo,
                TelefonoMovil = datos.TelefonoMovil,
                DescripcionPerfil = datos.DescripcionPerfil
            });

            return Ok(listaDatos);
        }
    }
}
