using GestionDeCitas.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCitas.Domain.Entities.Citas
{
    public class HistorialCita : BaseEntity
    {
        public int PacienteId { get; set; }
        public int CitaId { get; set; }
        public string? Observaciones { get; set; }
    }
}
