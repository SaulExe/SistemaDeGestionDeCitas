using System;

public class Cita
{
    public int CitaId { get; set; }
    public DateTime Fecha { get; set; }
    public int MedicoId { get; set; }
    public Medico Medico { get; set; }
    public int PacienteId { get; set; }
    public Paciente Paciente { get; set; }
}

