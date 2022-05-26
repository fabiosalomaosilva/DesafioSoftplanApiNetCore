using DesafioSoftplan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioSoftplan.Infra.Data.Validations
{
    internal class UserValidationConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired().UseIdentityColumn();
            builder.Property(p => p.JsonInfo).IsRequired();
        }
    }
}