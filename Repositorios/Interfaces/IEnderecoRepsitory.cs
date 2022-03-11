using ValidacaoTec.Models;

namespace ValidacaoTec.Repositorios.Interfaces
{
    public interface IEnderecoRepsitory
    {
        IEnumerable<Endereco> Enderecos { get; }
        Endereco GetEnderecoById(int enderecoId);

        void CriarEndereco(Endereco endereco);
        void Save();
    }
}
