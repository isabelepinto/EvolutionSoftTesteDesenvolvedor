using CadastroDePessoas.Models;
using CadastroDePessoas.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroDePessoas.Data.Map
{
    public class CadastroMap : IEntityTypeConfiguration<ContatoModel>
    {
        public void Configure(EntityTypeBuilder<ContatoModel> builder)
        {
            builder.HasKey(x => x.PessoaId);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Celular).IsRequired().HasMaxLength(11);
            builder.Property(x => x.StatusCadastro).IsRequired();
        }
    }
}