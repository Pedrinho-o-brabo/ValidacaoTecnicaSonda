using Microsoft.AspNetCore.Mvc;
using ValidacaoTec.Repositorios.Interfaces;
using ValidacaoTec.ViewModels;

namespace ValidacaoTec.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IEnderecoRepsitory _enderecoRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository, IEnderecoRepsitory enderecoRepsitory  )
        {
            _usuarioRepository = usuarioRepository;
            _enderecoRepository = enderecoRepsitory;
           
        }

        public IActionResult List()
        {

            var usuarios = _usuarioRepository.Usuarios;
            return View(usuarios);

        }
        public IActionResult Details(int id)
        {
            var endereco = _enderecoRepository.Enderecos.Where(i => i.UsuarioId == id).FirstOrDefault();
            var usuario = _usuarioRepository.GetUsuarioById(id);
            UsuarioEnderecoViewModel vw = new UsuarioEnderecoViewModel();
            vw.Usuario = usuario;
            vw.Endereco = endereco;
            

            
            return View(vw);
        }
        public IActionResult Create()
        {

           return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create(UsuarioEnderecoViewModel usuarioEnderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                var usuario = usuarioEnderecoViewModel.Usuario;
                var endereco = usuarioEnderecoViewModel.Endereco;
                

                _usuarioRepository.CriarUsuario(usuario);
                _usuarioRepository.Save();
                endereco.UsuarioId = usuario.UsuarioId;
                _enderecoRepository.CriarEndereco(endereco);
               
                _enderecoRepository.Save();
            }
            return View(usuarioEnderecoViewModel);
        }




    }
}
