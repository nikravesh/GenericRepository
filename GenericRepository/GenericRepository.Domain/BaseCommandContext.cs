using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Data;
public class BaseCommandContext : DbContext
{
    public BaseCommandContext(DbContextOptions options) : base(options)
    {
    }

    protected BaseCommandContext() { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
    }
}
