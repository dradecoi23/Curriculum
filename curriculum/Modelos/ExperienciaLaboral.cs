using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curriculum.Modelos
{
    public class ExperienciaLaboral
    {
        public Guid IdUsuario { get; set; }
        public string NombreEmpresa { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int AñosLaborados
        {
            get{
                return FechaFinal.Year - FechaInicial.Year;
            }
        }
        public string DescripcionCargo { get; set; }
        public string JefeInmediato { get; set; }
        public string TelefonoContacto { get; set; }
    }
}