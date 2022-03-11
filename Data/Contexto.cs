using Microsoft.EntityFrameworkCore;
using ValidacaoTec.Models;

namespace ValidacaoTec.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
