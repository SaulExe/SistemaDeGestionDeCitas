using System.Collections.Generic;
using System.Threading.Tasks;

public class CitaRepository : BaseRepository<Cita>, ICitaRepository
{
    private readonly CitasContext _context;

    public CitaRepository(CitasContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Cita>> GetCitasByMedicoAsync(int medicoId)
    {
        return await _context.Citas.Where(c => c.MedicoId == medicoId).ToListAsync();
    }

    public async Task<IEnumerable<Cita>> GetCitasByPacienteAsync(int pacienteId)
    {
        return await _context.Citas.Where(c => c.PacienteId == pacienteId).ToListAsync();
    }
}
