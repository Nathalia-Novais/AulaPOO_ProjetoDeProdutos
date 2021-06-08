using System;
using System.Collections.Generic;
using Projeto_produtos.interfaces;

namespace Projeto_produtos.classes
{
    public class Marca : IMarca
    {


        private int Codigo { get; set; }
        private string NomeMarca { get; set; }
        private DateTime DataCadastro { get; set; }
        List<Marca> ListaMarca = new List<Marca>();

        public Marca()
        {

        }
        public Marca(int _codigo, string _nomemarca)
        {
            this.NomeMarca = _nomemarca;
            this.Codigo = _codigo;
            DataCadastro = DateTime.Now;
        }


        public string Cadastrar(Marca marca)
        {
            ListaMarca.Add(marca);
            return "Marca cadastrada";
        }

        public string Deletar(Marca marca)
        {
             Console.WriteLine($"Qual o nome da marca que você deseja remover?");
             string MarcaDeletada= Console.ReadLine();

            ListaMarca.RemoveAll(x => x.NomeMarca == MarcaDeletada);
            return "Deletado";
        }


    }
}