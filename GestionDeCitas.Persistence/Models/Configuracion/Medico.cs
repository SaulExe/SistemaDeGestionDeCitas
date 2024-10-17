using System.Collections.Generic;

public class Medico
{
    public int MedicoId { get; set; }
    public string Nombre { get; set; }
    public ICollection<Especialidad> Especialidades { get; set; }
}
