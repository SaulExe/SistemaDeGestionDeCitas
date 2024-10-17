using System.Threading.Tasks;

public interface IMedicoRepository : IBaseRepository<Medico>
{
    Task<Medico> GetMedicoWithEspecialidadesAsync(int medicoId);
}
