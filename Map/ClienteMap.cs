using ApiPag.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiPag.Map;

public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
{
    public void Configure(EntityTypeBuilder<ClienteModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x =>x.NomeCliente).IsRequired().HasMaxLength(300);
        builder.Property(x => x.CodigoBanco).IsRequired();
    }

}
