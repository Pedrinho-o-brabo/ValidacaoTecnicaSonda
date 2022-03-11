using Microsoft.AspNetCore.Mvc;
using ValidacaoTec.Repositorios.Interfaces;
using ValidacaoTec.ViewModels;

namespace ValidacaoTec.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepsitory _enderecoRepository;

        public EnderecoController(IEnderecoRepsitory enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
        public IActionResult List()
        {
            var vw = new UsuarioEnderecoViewModel();
            
            return View(vw);
        }
    }
}
