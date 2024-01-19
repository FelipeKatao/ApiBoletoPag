using ApiPag.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiPag.Map;

public class BoletoMap : IEntityTypeConfiguration<BoletoModel>
{
    public void Configure(EntityTypeBuilder<BoletoModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NomePagador).IsRequired();
        builder.Property(x => x.NomeBeneficiario).IsRequired();
        builder.Property(x => x.CPF_Pagador);
        builder.Property(x => x.CNPJ_pagador);
        builder.Property(x => x.ValorBoleto).IsRequired();
        builder.Property(x => x.BancoId).IsRequired();
        builder.Property(x => x.ClientId).IsRequired();
        builder.Property(x => x.Vencimento).IsRequired();
        builder.Property(x => x.Observacao);
    }
}
