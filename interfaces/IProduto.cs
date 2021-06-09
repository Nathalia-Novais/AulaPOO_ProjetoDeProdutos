using System.Collections.Generic;
using Projeto_produtos.classes;

namespace Projeto_produtos.interfaces
{
    public interface IProduto
    {
        string Cadastrar(Produto produto);
        List<Produto> Listar();
        string Deletar(Produto produto);
    }
}