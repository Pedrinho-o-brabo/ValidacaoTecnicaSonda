using System.ComponentModel.DataAnnotations;

namespace ValidacaoTec.Models
{
    public class Endereco
    {


        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public int EnderecoId { get; set; }
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public String CEP { get; set; }
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public String Logradouro { get; set; }
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public String Complemento { get; set; }
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public String Bairro { get; set; }
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public String Cidade { get; set; }
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public String Estado { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
