using Chapter.Contexts;
using Chapter.Models;
using Microsoft.Identity.Client;
using System.Runtime.CompilerServices;

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

        public Projeto BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void Cadastrar(Projeto p)
        {
            _context.Projetos.Add(p);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
           Projeto p = _context.Projetos.Find(id);
           _context.Projetos.Remove(p);
           _context.SaveChanges();  
        }

        public void Alterar (int id, Projeto p)
        {
            Projeto projetobuscado = _context.Projetos.Find (id);
            if (projetobuscado != null)
            {
               projetobuscado.NomeDoProjeto = p.NomeDoProjeto;
               projetobuscado.Area = p.Area;
               projetobuscado.Status = p.Status;
               _context.Projetos.Update(projetobuscado);
               _context.SaveChanges();
            }
        }
    }
}
