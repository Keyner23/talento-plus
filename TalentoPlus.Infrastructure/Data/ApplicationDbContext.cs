using Microsoft.EntityFrameworkCore;
using TalentoPlus.Core.Entities;

namespace TalentoPlus.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSet de Empleados
    public DbSet<Empleado> Empleados { get; set; } = null!;
}
