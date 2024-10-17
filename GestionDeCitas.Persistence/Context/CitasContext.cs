public class CitasContext : DbContext
{
    public DbSet<Cita> Citas { get; set; }
    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<Notificacion> Notificaciones { get; set; }

    public CitasContext(DbContextOptions<CitasContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Configuraciones adicionales
    }
}
