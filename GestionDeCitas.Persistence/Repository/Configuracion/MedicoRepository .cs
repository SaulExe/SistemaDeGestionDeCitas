using System.Threading.Tasks;

public class MedicoRepository : BaseRepository<Medico>, IMedicoRepository
{
    private readonly CitasContext _context;

    public MedicoRepository(CitasContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Medico> GetMedicoWithEspecialidadesAsync(int medicoId)
    {
        return await _context.Medicos
            .Include(m => m.Especialidades)
            .FirstOrDefaultAsync(m => m.MedicoId == medicoId);
    }
}
