using Microsoft.EntityFrameworkCore;
using ValidacaoTec.Data;
using ValidacaoTec.Models;
using ValidacaoTec.Repositorios.Interfaces;

namespace ValidacaoTec.Repositorios
{
    public class EnderecoRepository : IEnderecoRepsitory
    {

        private readonly Contexto _contexto;
        
        public EnderecoRepository(Contexto contexto)
        {
            _contexto = contexto;
            
        }
        public IEnumerable<Endereco> Enderecos => _contexto.Enderecos.Include(c => c.Usuario);

        public void CriarEndereco(Endereco endereco)
        {
            _contexto.Enderecos.Add(endereco);
        }

        public Endereco GetEnderecoById(int enderecoId)
        {
           return _contexto.Enderecos.FirstOrDefault(e => e.EnderecoId == enderecoId);
        }

        public void Save()
        {
            _contexto.SaveChanges();
        }
    }
}
