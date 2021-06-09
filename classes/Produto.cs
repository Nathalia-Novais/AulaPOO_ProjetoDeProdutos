using System;
using System.Collections.Generic;
using Projeto_produtos.interfaces;

namespace Projeto_produtos.classes
{
    public class Produto : IProduto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca marca { get; set; }
        public Usuario CadastradoPor { get; set; }
        
         List<Produto> ListaProduto = new List<Produto>(); 
        public Produto()
        {

        }
        public Produto(int _codigo, string _nomeproduto, float _preco, Marca _marca, Usuario _cadastradopor)  
        {
            this.Codigo = _codigo;
            this.NomeProduto = _nomeproduto;
            this.Preco = _preco;
            this.DataCadastro = DateTime.Now;
            this.marca = _marca;
            this.CadastradoPor = _cadastradopor;
        } 
        
        public string Cadastrar(Produto produto)
        {
            ListaProduto.Add(produto);
            return "Produto cadastrado com sucesso ";
        }

        public string Deletar(Produto produto)
        {
          ListaProduto.RemoveAll(x => x.NomeProduto == produto.NomeProduto);
            return "Produto deletado com sucesso";
        }

        public List<Produto> Listar()
        {
           return ListaProduto;
        }
    }
}