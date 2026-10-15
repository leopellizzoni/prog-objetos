using System;

namespace ExemploComInterfaces.Biblioteca;

public class LivroFisico : ILivro
{
    public String Titulo { get; set; }

    public String LocalNaEstante { get; set; }
}
