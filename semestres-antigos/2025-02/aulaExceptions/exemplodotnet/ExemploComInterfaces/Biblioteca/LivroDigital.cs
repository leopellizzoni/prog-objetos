using System;

namespace ExemploComInterfaces.Biblioteca;

public class LivroDigital : ILivro
{
    public String Titulo { get; set; }

    public String URL { get; set; }
}
