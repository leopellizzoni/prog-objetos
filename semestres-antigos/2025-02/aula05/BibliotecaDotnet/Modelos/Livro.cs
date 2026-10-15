using System;

namespace BibliotecaDotnet.Modelos;

//comentario de teste para o commit do github
public class Livro : ObjetoComId
{

    //encadeamento dos construtores atraves do this()
    public Livro(String titulo, String autor) 
    {
        this.Titulo = titulo;
        this.Autor = autor; 
    }

    //encadeamento dos construtores atraves do this()
    public Livro(String titulo, String autor, int isbn, DateTime publicacao) : this(titulo, autor)
    {
        this.ISBN = isbn;
        this.DataDePublicacao = publicacao;
    }

    public String Titulo { get; set; }

    public String Autor { get; set; }

    public int ISBN { get; set; }

    public DateTime DataDePublicacao { get; set; }

    public String Categoria { get; set; }

    public int Status { get; set; }

    public String ObterDescricao()
    {
        return $"Título: {Titulo} | Autor: {Autor} | ISBN: {ISBN}";
    }

    public void ImprimirDescricao()
    {
        Console.WriteLine(ObterDescricao());
    }
}
