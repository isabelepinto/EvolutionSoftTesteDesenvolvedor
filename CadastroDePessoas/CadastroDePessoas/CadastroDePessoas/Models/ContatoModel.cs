using CadastroDePessoas.Enums;
using System.ComponentModel.DataAnnotations;

namespace CadastroDePessoas.Models
{
    public class ContatoModel
    {
        [Required]
        public int PessoaId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Celular { get; set; }
        public CadastroPessoas StatusCadastro { get; set; }
    }
}
