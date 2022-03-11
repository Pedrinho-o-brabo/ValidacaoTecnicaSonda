using ValidacaoTec.Models;

namespace ValidacaoTec.Repositorios.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> Usuarios { get; }
        Usuario GetUsuarioById(int usuarioId);

        void CriarUsuario(Usuario usuario);
        void Save();
    }
}
