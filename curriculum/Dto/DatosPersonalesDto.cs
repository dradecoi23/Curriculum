using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curriculum.Dto
{
    public class DatosPersonalesDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Profesion { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string DescripcionPerfil { get; set; }
        public string Nacionalidad { get; set; }
    }
}
