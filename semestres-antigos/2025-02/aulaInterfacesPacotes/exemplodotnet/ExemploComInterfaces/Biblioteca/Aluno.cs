using System;

namespace ExemploComInterfaces.Biblioteca;

public class Aluno : IUsuario
{
    public int DiasLiberado()
    {
        return 10;
    }
}
