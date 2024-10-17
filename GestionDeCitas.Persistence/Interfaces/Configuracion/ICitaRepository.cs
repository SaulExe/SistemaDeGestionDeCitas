using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICitaRepository : IBaseRepository<Cita>
{
    Task<IEnumerable<Cita>> GetCitasByMedicoAsync(int medicoId);
    Task<IEnumerable<Cita>> GetCitasByPacienteAsync(int pacienteId);
}
