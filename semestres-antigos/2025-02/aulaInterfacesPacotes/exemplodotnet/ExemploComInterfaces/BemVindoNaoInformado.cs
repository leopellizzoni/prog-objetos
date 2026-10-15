using System;

namespace ExemploComInterfaces;

public class BemVindoNaoInformado : IBemVindo
{
    public string ObterMensagem()
    {
        return "-----------NAO INFORMADO";
    }
}