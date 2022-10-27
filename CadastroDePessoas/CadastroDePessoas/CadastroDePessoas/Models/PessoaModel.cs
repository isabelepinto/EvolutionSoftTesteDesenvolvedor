namespace CadastroDePessoas.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
    }
}
