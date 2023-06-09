using Chapter.Contexts;
using Chapter.Models;
using Microsoft.Identity.Client;

namespace Chapter.Repositories
{
    public class ProjetoRepository
    {
        private readonly Sqlcontext _context;

        public ProjetoRepository(Sqlcontext context) {
            //
            _context = context;

        }
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }
    }
}
