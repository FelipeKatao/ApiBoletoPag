using ApiPag.Dominio.Cliente;
using ApiPag.Map;
using ApiPag.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiPag.Data.Boleto_Dados;

public class BoletosContext:DbContext
{

    public BoletosContext(DbContextOptions<BoletosContext> options):base(options)
    {}

    public DbSet<BoletoModel> Boletos {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BoletoMap());
        base.OnModelCreating(modelBuilder);
    }
}
