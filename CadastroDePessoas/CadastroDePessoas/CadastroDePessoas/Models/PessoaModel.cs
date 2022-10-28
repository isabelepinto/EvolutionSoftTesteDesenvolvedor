using System.ComponentModel.DataAnnotations;

namespace CadastroDePessoas.Models
{
    public class PessoaModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Cpf { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
        public List<PessoaModel> PessoaList { get; set; }
    }
}
