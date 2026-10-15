using System;

namespace ConsoleAppAula01;

public class ExcecaoDeRegraDoSistema : Exception
{
    public ExcecaoDeRegraDoSistema(String mensagem) : base(mensagem)   
    {
        
    }

    public ExcecaoDeRegraDoSistema(String mensagem, Exception ex) : base(mensagem, ex)
    {
        
    }
}
