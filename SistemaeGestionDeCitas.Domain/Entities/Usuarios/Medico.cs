using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCitas.Domain.Entities.Usuarios
{
    public class Medico : Usuario
    {
        public string? Especialidad { get; set; }
        public string? NumeroLicencia { get; set; }
        public decimal TarifaConsulta { get; set; }
    }
}
