﻿using System.Collections.Generic;

public class Especialidad
{
    public int EspecialidadId { get; set; }
    public string Nombre { get; set; }
    public ICollection<Medico> Medicos { get; set; }
}
