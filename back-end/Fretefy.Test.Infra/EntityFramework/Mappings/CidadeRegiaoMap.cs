using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class CidadeRegiaoMap : IEntityTypeConfiguration<CidadeRegiao>
    {
        public void Configure(EntityTypeBuilder<CidadeRegiao> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NomeCidade).HasMaxLength(50).IsRequired();

        }
    }
}