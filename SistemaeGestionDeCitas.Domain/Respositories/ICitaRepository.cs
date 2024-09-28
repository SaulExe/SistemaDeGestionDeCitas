using GestionDeCitas.Domain.Entities.Citas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCitas.Domain.Respositories
{
    public interface ICitaRepository : IBaseRepository<Cita>
    {
        Task<IEnumerable<Cita>> GetCitasByPacienteIdAsync(int pacienteId);
        Task<IEnumerable<Cita>> GetCitasByMedicoIdAsync(int medicoId);
    }
}
