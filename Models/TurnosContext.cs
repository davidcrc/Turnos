using Microsoft.EntityFrameworkCore;

namespace Turnos.Models
{
  public class TurnosContext : DbContext
  {
    // Constructor
    public TurnosContext(DbContextOptions<TurnosContext> opciones)
    : base(opciones)
    {

    }

    public DbSet<Especialidad> Especialidad { get; set; }
  }
}