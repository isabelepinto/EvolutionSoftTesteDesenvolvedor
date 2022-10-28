using CadastroDePessoas.Data.Map;
using CadastroDePessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDePessoas.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext>options)
           : base(options)
        {}

        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<ContatoModel> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CadastroMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
