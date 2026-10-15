using System;

namespace ExemploComInterfaces;

public class BemVindoIngles : IBemVindo
{
    public string ObterMensagem()
    {
        return "Hello, World!";
    }
}
