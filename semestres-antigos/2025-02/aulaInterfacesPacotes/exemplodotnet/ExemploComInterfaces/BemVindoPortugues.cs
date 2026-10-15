using System;

namespace ExemploComInterfaces;

public class BemVindoPortugues : IBemVindo
{
    public string ObterMensagem()
    {
       return "Olá, Mundo";
    }
}
