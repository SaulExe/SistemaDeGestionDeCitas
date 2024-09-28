using GestionDeCitas.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCitas.Domain.Entities.Notificaciones
{
    public class Notificacion : BaseEntity
    {
        public int UsuarioId { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        public bool Enviado { get; set; }
    }
}
