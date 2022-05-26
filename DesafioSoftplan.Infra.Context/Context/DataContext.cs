using DesafioSoftplan.Infra.Data.Validations;
using Microsoft.EntityFrameworkCore;

namespace DesafioSoftplan.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserValidationConfig());
            modelBuilder.ApplyConfiguration(new CountryValidationConfig());
        }
    }
}