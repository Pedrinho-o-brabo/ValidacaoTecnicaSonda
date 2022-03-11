using ValidacaoTec.Data;
using ValidacaoTec.Models;
using ValidacaoTec.Repositorios.Interfaces;

namespace ValidacaoTec.Repositorios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Contexto _context;

        public UsuarioRepository(Contexto context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> Usuarios => _context.Usuarios;

        public void CriarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }

        public Usuario GetUsuarioById(int usuarioId)
        {
            return _context.Usuarios.FirstOrDefault(u => u.UsuarioId == usuarioId);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
