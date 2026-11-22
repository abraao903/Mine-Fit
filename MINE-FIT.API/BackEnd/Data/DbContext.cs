using Microsoft.EntityFrameworkCore;

namespace MINE_FIT.API;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Alunos> Aluno => Set<Alunos>();

    public DbSet<Instrutores> Instrutor => Set<Instrutores>();
}
