using Microsoft.EntityFrameworkCore;
using ApiPag.Model;
using ApiPag.Map;
namespace ApiPag.Dominio.Cliente;

public class ClienteContext: DbContext
{
    public ClienteContext(DbContextOptions<ClienteContext> options):base(options)
    {}
    public DbSet<ClienteModel> Cliente {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClienteMap());
        base.OnModelCreating(modelBuilder);
    }
}