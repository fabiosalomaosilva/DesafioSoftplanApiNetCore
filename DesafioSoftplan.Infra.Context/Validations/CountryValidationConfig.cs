using DesafioSoftplan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioSoftplan.Infra.Data.Validations
{
    internal class CountryValidationConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired().UseIdentityColumn();
            builder.Property(p => p.JsonInfo).IsRequired();
        }
    }
}