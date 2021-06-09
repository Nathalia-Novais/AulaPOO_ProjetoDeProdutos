using System;
using System.Collections.Generic;
using Projeto_produtos.interfaces;

namespace Projeto_produtos.classes
{
    public class Usuario : IUsuario
    {
        public int Codigo { get; set; }
        public string Nome  { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Usuario> ListaUsuario= new List<Usuario>();
        public Usuario(){

        }

        public Usuario(int _codigo,string _nomeusuario, string _email , string _senha){


        }

        public string Cadastrar(Usuario usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            ListaUsuario.Add(usuario);

            return $"Usuário {usuario.Nome} Cadastrado com sucesso";

        }

        public string Deletar(Usuario usuario)
        {
            Console.WriteLine("Qual é o nome do usuario que você deseja deletar?");
            string deletarusuario = Console.ReadLine();
           
            ListaUsuario.RemoveAll(x => x.Nome == deletarusuario);
             return $"Usuário {deletarusuario} deletado com sucesso";
        }
    }
}