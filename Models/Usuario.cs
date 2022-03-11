using System.ComponentModel.DataAnnotations;

namespace ValidacaoTec.Models
{
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public string UsuarioNome { get; set; }
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public string UsuarioCpf { get; set; }
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public string UsuarioEmail { get; set; }
        [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
        public DateTime UsuarioDataDeNascimento { get; set; }

        public List<Endereco> Enderecos { get; set; }



    }
}
