using Microsoft.EntityFrameworkCore;

namespace JayAPI.Models
{
    public class JayContexto :DbContext
    {
       
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
       
        public JayContexto(DbContextOptions<JayContexto>options):base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(p => p.id);
            modelBuilder.Entity<Endereco>().HasKey(p => p.id);
            modelBuilder.Entity<Fornecedor>().HasKey(p => p.id);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
