using GestionDeCitas.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCitas.Domain.Entities.Reportes
{
    public class ReporteCita : BaseEntity
    {
        public int MedicoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string? TipoReporte { get; set; } // Realizadas, Canceladas, Pendientes
    }
}
