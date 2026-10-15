using System;

namespace ExemploComInterfaces.Biblioteca;

public class Emprestimo
{
    public DateTime QuandoDevolver { get; set; }

    public ILivro Livro {get;set;}

    public IUsuario Usuario {get;set;}
}
