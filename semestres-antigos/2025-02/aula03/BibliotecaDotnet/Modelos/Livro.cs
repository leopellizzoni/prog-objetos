using System;

namespace BibliotecaDotnet.Modelos;

public class Livro
{   
    public Livro(String titulo, String autor)
    {
        this.Titulo = titulo;
        this.Autor = autor; 
    }

    public Livro(String titulo, String autor, int isbn, DateTime publicacao)
    {
        this.Titulo = titulo;
        this.Autor = autor;
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
