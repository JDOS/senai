using Chapter.Contexts;
using Chapter.Interfaces;
using Chapter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace Chapter.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly Sqlcontext _context;

        public UsuarioRepository(Sqlcontext context)
        {
            //
            _context = context;

        }

        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuariobuscado = _context.Usuarios.Find(id);
            if (usuariobuscado != null)
            {
                usuariobuscado.Email = usuario.Email;
                usuariobuscado.Senha = usuario.Senha;
                usuariobuscado.Tipo = usuario.Tipo;
                _context.Usuarios.Update(usuariobuscado);
                _context.SaveChanges();
            }
        }

        public Usuario BuscaPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            _context.Usuarios.Add(novoUsuario);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario u = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(u);
            _context.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            // Usuario u = _context.Usuarios.Find(email);
            //if (u.Senha == password) {
            //    return u;
            // }
            return _context.Usuarios.First(u =>
            u.Email == email &&
            u.Senha == senha
            );

        }
    }
}
