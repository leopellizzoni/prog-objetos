using System;
using BibliotecaDotnet.Modelos;

namespace BibliotecaDotnet;

public class GerenciadorDeBiblioteca
{
    Livro[] todosLivros = new Livro[2];
    Usuario[] todosUsuarios = new Usuario[1];

    public GerenciadorDeBiblioteca()
    {
        InicializarValores();
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

    private void InicializarValores()
    {
        todosLivros[0] = new Livro("Os Inovadores", "Isaac", 01, new DateTime(2020, 01, 01));
        todosLivros[1] = new Livro("Programador Pragmático", "Andy Hunt, Dave Thomas", 02, new DateTime(2020, 02, 02));

        todosUsuarios[0] = new Usuario(1, "Usuário 1", "usuarioa1@ucs.br", "+555411111111");
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
        
        for (int i = 0; i < todosLivros.Length; i++)
        {
            todosLivros[i].ImprimirDescricao();
        }
    }

    private void ListarTodosUsuarios()
    {
        ImprimirOperacao("Todos os Usuários");

        foreach (Usuario usuario in todosUsuarios)
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

        Livro[] novosLivros = new Livro[todosLivros.Length + 1];

        for (int i = 0; i < todosLivros.Length; i++)
        {
            novosLivros[i] = todosLivros[i];
        }

        novosLivros[novosLivros.Length - 1] = new Livro(titulo, autor);
        
        todosLivros = novosLivros;
    }

    private void CadastrarUsuario()
    {
        int novoId = todosUsuarios.Length + 1;

        Console.Write("Informe o nome: ");
        String nome = Console.ReadLine();
        Console.Write("Informe o WhatsApp: ");
        String wa = Console.ReadLine();

        Usuario[] novosUsuarios = new Usuario[todosUsuarios.Length + 1];

        for (int i = 0; i < todosUsuarios.Length; i++)
        {
            novosUsuarios[i] = todosUsuarios[i];
        }

        novosUsuarios[novosUsuarios.Length - 1] = new Usuario(novoId, nome, wa);
        
        todosUsuarios = novosUsuarios;
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
