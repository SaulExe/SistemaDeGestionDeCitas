using GestionDeCitas.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCitas.Domain.Entities.Citas
{
    public class Cita : BaseEntity
    {
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public DateTime FechaCita { get; set; }
        public string? MotivoConsulta { get; set; }
        public string? Diagnostico { get; set; }
        public string? Estado { get; set; } // Pendiente, Confirmada, Cancelada, etc.
    }
}
