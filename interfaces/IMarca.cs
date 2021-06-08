using System.Collections.Generic;
using Projeto_produtos.classes;

namespace Projeto_produtos.interfaces
{
    public interface IMarca
    {
        string Cadastrar(Marca marca);
        string Deletar(Marca marca);
    }
}