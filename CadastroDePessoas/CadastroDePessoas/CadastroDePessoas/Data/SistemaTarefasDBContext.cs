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
    }
}
