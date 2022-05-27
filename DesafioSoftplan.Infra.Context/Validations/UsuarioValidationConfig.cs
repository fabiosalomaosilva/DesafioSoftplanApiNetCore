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
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.Password);
            builder.Property(p => p.Photo);
            builder.Property(p => p.LoginProvider);
            builder.Property(p => p.Street);
            builder.Property(p => p.Number);
            builder.Property(p => p.District);
            builder.Property(p => p.Complementar);
            builder.Property(p => p.ZipCode);
            builder.Property(p => p.City);
            builder.Property(p => p.State);

            builder.HasData(new User
            {
                Id = 1,
                Name = "Administrador",
                Email = "teste@teste.com",
                Password = "C8E453E305380C3C103BE203AA7720F444333D6F"
            });
        }
    }
}