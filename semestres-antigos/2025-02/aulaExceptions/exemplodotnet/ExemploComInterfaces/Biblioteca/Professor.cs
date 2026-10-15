using System;

namespace ExemploComInterfaces.Biblioteca;

public class Professor : IUsuario
{
    public int DiasLiberado()
    {
       return 15;
    }
}
