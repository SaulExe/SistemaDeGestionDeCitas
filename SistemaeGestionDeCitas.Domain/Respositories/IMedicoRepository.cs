using GestionDeCitas.Domain.Entities.Citas;
using GestionDeCitas.Domain.Entities.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCitas.Domain.Respositories
{
    public interface IMedicoRepository : IBaseRepository<Medico>
    {
        // Método para obtener médicos por especialidad
        Task<IEnumerable<Medico>> GetMedicosByEspecialidadAsync(string especialidad);

        // Método para obtener disponibilidad del médico en un rango de fechas
        Task<IEnumerable<DisponibilidadMedico>> GetDisponibilidadByMedicoIdAsync(int medicoId, DateTime fechaInicio, DateTime fechaFin);

        // Método para obtener un médico por su número de licencia
        Task<Medico> GetMedicoByNumeroLicenciaAsync(string numeroLicencia);
    }
}
