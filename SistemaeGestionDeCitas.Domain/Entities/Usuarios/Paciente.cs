using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCitas.Domain.Entities.Usuarios
{
    public class Paciente : Usuario
    {
        public string? NumeroSeguroSocial { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string?  ProveedorDeSeguro { get; set; }
    }
}
