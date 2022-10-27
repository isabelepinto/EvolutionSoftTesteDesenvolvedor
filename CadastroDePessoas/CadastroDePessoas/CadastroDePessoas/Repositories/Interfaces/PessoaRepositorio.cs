using CadastroDePessoas.Data;
using CadastroDePessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDePessoas.Repositories.Interfaces
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private readonly SistemaTarefasDBContext _dBContext;
        public PessoaRepositorio(SistemaTarefasDBContext sistemaTarefasDBContext)
        {
            _dBContext = sistemaTarefasDBContext;
        }
        public async Task<PessoaModel> BuscarPorId(int id)
        {
            return await _dBContext.Pessoas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<PessoaModel>> BuscarTodasPessoas()
        {
            return await _dBContext.Pessoas.ToListAsync();
        }
        public async Task<PessoaModel> Adicionar(PessoaModel pessoa)
        {
            _dBContext.Pessoas.Add(pessoa);
            _dBContext.SaveChanges();
            return pessoa;
        }

        public async Task<bool> Apagar(int id)
        {
            PessoaModel pessoaPorId = await BuscarPorId(id);
            if (pessoaPorId == null)
            {
                throw new Exception($"A pessoa para o ID {id}: não foi encontrada.");
            }

            _dBContext.Pessoas.Remove(pessoaPorId);
            _dBContext.SaveChanges();
           
            return true;
        }

        public async Task<PessoaModel> Atualizar(PessoaModel pessoa, int id)
        {
            PessoaModel pessoaPorId = await BuscarPorId(id);
            if (pessoaPorId == null)
            {
                throw new Exception($"A pessoa para o ID {id}: não foi encontrada.");
            }
            pessoaPorId.Nome = pessoa.Nome;
            pessoaPorId.Email = pessoa.Email;
            pessoaPorId.Cpf = pessoa.Cpf;

            _dBContext.Pessoas.Update(pessoaPorId);
            _dBContext.SaveChanges();

            return pessoaPorId;
        }

        
    }
}
