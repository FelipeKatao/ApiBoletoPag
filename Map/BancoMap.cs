using ApiPag.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiPag.Map;

public class BancoMap : IEntityTypeConfiguration<BancoModel>
{
    public void Configure(EntityTypeBuilder<BancoModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NomeDoBanco).IsRequired();
        builder.Property(x => x.CodigoBanco).IsRequired();
        builder.Property(x => x.PercentualJuros);
    }

}
