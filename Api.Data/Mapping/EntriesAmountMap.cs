using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class EntriesAmountMap : IEntityTypeConfiguration<EntriesAmountEntity>
    {
        public void Configure(EntityTypeBuilder<EntriesAmountEntity> builder)
        {
            builder.ToTable("EntriesAmount");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.DateLaunch);

            builder.HasOne(u => u.Category);
        }
    }
}
