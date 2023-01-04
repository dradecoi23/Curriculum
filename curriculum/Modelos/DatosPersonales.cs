using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curriculum.Modelos
{
    // clase
    public class DatosPersonales
    {
        public DatosPersonales()
        {
            IdUsuario = Guid.NewGuid();
        }
        // propiedades
         
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad
        {
            get {
                return DateTime.Now.Year - FechaNacimiento.Year; 
            }
        }

        public string Profesion  { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string TelefonoFijo{ get; set; }
        public string TelefonoMovil { get; set; }
        public string DescripcionPerfil { get; set; }

        public Guid IdUsuario { get; set; }

        public string Nacionalidad { get; set; }

    }
}
