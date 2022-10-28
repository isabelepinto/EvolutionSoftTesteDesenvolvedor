using System.ComponentModel;

namespace CadastroDePessoas.Enums
{
    public enum CadastroPessoas
    {
        [Description("Solicitando Cadastro")]
        ACadastrar = 1,
        [Description("Cadastro em andamento")]
        EmAndamento = 2,
        [Description("Cadastro concluído")]
        Concluido = 3
    }
}
