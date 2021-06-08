using System.Collections.Generic;
using Projeto_produtos.classes;

namespace Projeto_produtos.interfaces
{
    public interface IMarca
    {
        string Cadastrar(Marca marca);
        List<Marca> Listar();
        string Deletar(Marca marca);
    }
}