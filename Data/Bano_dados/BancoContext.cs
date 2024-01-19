using ApiPag.Map;
using ApiPag.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiPag.Data.Bano_dados;

public class BancoContext: DbContext
{
    public BancoContext(DbContextOptions<BancoContext> options):base(options)
    {
    }

    public DbSet<BancoModel> Banco {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BancoMap());
        base.OnModelCreating(modelBuilder);
    }
}
