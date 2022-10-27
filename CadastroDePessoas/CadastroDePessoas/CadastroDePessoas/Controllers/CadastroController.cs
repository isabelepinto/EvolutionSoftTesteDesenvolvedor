using CadastroDePessoas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDePessoas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<PessoaModel>> BuscarTodasPessoas()
        {
            return Ok();
        }
        
    }
}
