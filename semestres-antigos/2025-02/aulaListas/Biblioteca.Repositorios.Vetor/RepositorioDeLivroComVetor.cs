using System;
using Biblioteca.Modelos;

namespace Biblioteca.Repositorios.Vetor;

public class RepositorioDeLivroComVetor
{
    private Livro[] todosLivros = new Livro[5];

    public RepositorioDeLivroComVetor()
    {
        todosLivros[0] = new Livro("Os Inovadores", "Isaac", 01, new DateTime(2020, 01, 01));
        todosLivros[1] = new Livro("Programador Pragmático", "Andy Hunt, Dave Thomas", 02, new DateTime(2020, 02, 02));
        todosLivros[2] = new Livro("O senhor das moscas", "Wiliam Golding");
        todosLivros[3] = new Livro("How to kill a mocking bird --------", "Herper Lee");
        todosLivros[4] = new Livro("O senhor das moscas - Edicao Comemorativa", "Wiliam Golding");
    }

    public void Adicionar(Livro livroNovo)
    {
        if (String.IsNullOrEmpty(livroNovo.Titulo))
        {
            throw new Exception("O livro precisa ter informado um titulo para ser cadastrado");
        }

        Livro[] novosLivros = new Livro[todosLivros.Length + 1];

        for (int i = 0; i < todosLivros.Length; i++)
        {
            novosLivros[i] = todosLivros[i];
        }

        novosLivros[novosLivros.Length - 1] = livroNovo;
        todosLivros = novosLivros;
    }

    public Livro[] ObterTodos()
    {
        return todosLivros.ToArray();
    }
}
