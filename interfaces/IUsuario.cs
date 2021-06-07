using Projeto_produtos.classes;

namespace Projeto_produtos.interfaces
{
    public interface IUsuario
    {
        string Cadastrar(Usuario usuario);
        string Deletar(Usuario usuario);
    }
}