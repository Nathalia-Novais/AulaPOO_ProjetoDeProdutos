using System;
using System.Collections.Generic;
using Projeto_produtos.interfaces;

namespace Projeto_produtos.classes
{
    public class Usuario : IUsuario
    {
        private int Codigo;
        private string Nome;
        private string Email;
        private string Senha;
        private DateTime DataCadastro;
        List<Usuario> usuarios = new List<Usuario>();

        public string Cadastrar(Usuario usuario)
        {

            Usuario _usuario = new Usuario();

            Console.WriteLine("Código do usuário:");
            _usuario.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do usuário:");
            _usuario.Nome = Console.ReadLine();

            Console.WriteLine("Email do usuário:");
            _usuario.Email = Console.ReadLine();

            Console.WriteLine("Senha do usuário:");
            _usuario.Senha = Console.ReadLine();

            _usuario.DataCadastro = DateTime.Now;

            usuarios.Add(_usuario);

            return "Usuário Cadastrado com sucesso";

        }

        public string Deletar(Usuario usuario)
        {
            Console.WriteLine("Qual é o nome do usuario que deseja deletar?");
            string deletarusuario = Console.ReadLine();
           
            usuarios.RemoveAll(x => x.Nome == deletarusuario);
            return "Usuário deletado com sucesso";
        }
    }
}