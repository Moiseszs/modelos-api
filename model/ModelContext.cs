using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace db_share.model
{
    public class ModelContext : DbContext
    {
        private readonly IConfiguration configuration;

        public ModelContext(IConfiguration _configuration){
            configuration = _configuration;
        }

        public DbSet<Categoria>? categorias {get; set;}

        public DbSet<Modelo>? modelos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = configuration.GetConnectionString("Connection");
            optionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
            .HasMany(e => e.Modelos)
            .WithOne(e => e.Categoria)
            .HasForeignKey(e => e.CategoriaId)
            .HasPrincipalKey(e => e.Id);
        }
    }
}