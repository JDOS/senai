using Chapter.Models;
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

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Projeto projetobuscado = _projetoRepository.BuscarPorId(id);
                if(projetobuscado==null){
                    return NotFound();
                }

                else {
                    return Ok(_projetoRepository.BuscarPorId(id));
                }
            }
            catch (Exception ex)
            {
                //return BadRequest(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Projeto p)
        {
            try
            {
                _projetoRepository.Cadastrar(p);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                //return BadRequest(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                 _projetoRepository.Deletar(id);
                return Ok("Projeto Removido com Sucesso");
            }
            catch (Exception ex)
            {
                //return BadRequest(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(int id, Projeto p)
        {
            try
            {
                _projetoRepository.Alterar(id, p);
                return Ok("Projeto alterado com Sucesso");
            }
            catch (Exception ex)
            {
                //return BadRequest(ex.Message);
                throw new Exception(ex.Message);
            }
        }

    }
}
