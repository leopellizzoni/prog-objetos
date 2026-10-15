using System;
using Biblioteca.Modelos;
using Biblioteca.Repositorios.Vetor;
using BibliotecaDotnet.Modelos;

namespace BibliotecaDotnet;

public class GerenciadorDeBiblioteca
{
    RepositorioDeLivroComVetor repositorioDeLivro;
    RepositorioDeUsuarioComVetor repositorioDeUsuario;

    public GerenciadorDeBiblioteca()
    {
        repositorioDeLivro = new RepositorioDeLivroComVetor();
        repositorioDeUsuario = new RepositorioDeUsuarioComVetor();
    }

    private void ImprimirSeparador()
    {
        Console.WriteLine("------------------------------------");
    }

    private void MostrarOpcoes()
    {
        ImprimirSeparador();
        Console.WriteLine("Sistema de Biblioteca");
        Console.WriteLine("1 - Listar todos os livros");
        Console.WriteLine("2 - Listar usuários");
        Console.WriteLine("3 - Cadastrar livro");
        Console.WriteLine("4 - Cadastrar usuário");
        Console.WriteLine("99 - Sair");
        Console.Write("Informe a opção: ");
    }

    private void ImprimirOperacao(string descricao)
    {
        ImprimirSeparador();
        Console.WriteLine(descricao);
        ImprimirSeparador();
    }

    private void ListarTodosLivros()
    {
        ImprimirOperacao("Todos os Livros");

        var livros = repositorioDeLivro.ObterTodos();

        for (int i = 0; i < livros.Length; i++)
        {
            livros[i].ImprimirDescricao();
        }
    }

    private void ListarTodosUsuarios()
    {
        ImprimirOperacao("Todos os Usuários");
        var usuarios = repositorioDeUsuario.ObterTodos();

        foreach (Usuario usuario in usuarios)
        {
            Console.WriteLine(usuario.ObterDescricaoPublica());
        }
    }

    private void CadastrarLivro()
    {
        Console.Write("Informe o titulo: ");
        String titulo = Console.ReadLine();
        Console.Write("Informe o autor:");
        String autor = Console.ReadLine();

        repositorioDeLivro.Adicionar(new Livro(titulo, autor));
    }

    private void CadastrarUsuario()
    {
        Console.Write("Informe o nome: ");
        String nome = Console.ReadLine();
        Console.Write("Informe o WhatsApp: ");
        String wa = Console.ReadLine();

        repositorioDeUsuario.Adicionar(new Usuario(nome, wa));
    }

    public void Iniciar()
    {
        int opcaoUsuario = 0;
        do
        {
            MostrarOpcoes();

            opcaoUsuario = int.Parse(Console.ReadLine());

            if (opcaoUsuario == 1)
            {
                ListarTodosLivros();
            }
            else if (opcaoUsuario == 2)
            {
                ListarTodosUsuarios();
            }
            else if (opcaoUsuario == 3)
            {
                CadastrarLivro();
            }
            else if (opcaoUsuario == 4)
            {
                CadastrarUsuario();
            }
        } while (opcaoUsuario != 99);

    }
}
