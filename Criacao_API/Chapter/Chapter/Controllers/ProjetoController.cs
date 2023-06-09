using Chapter.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter.Controllers
{
    //saida do JSON
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly ProjetoRepository? _projetoRepository;
        public ProjetoController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public IActionResult listar()
        {
            try
            {
                return Ok(_projetoRepository.Listar());
            }
            catch (Exception ex)
            {
                //return BadRequest(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
