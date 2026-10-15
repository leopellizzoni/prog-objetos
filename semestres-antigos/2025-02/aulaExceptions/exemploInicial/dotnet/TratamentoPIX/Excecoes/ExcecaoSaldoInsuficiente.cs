using System;

namespace TratamentoPIX.Excecoes;

public class ExcecaoSaldoInsuficiente : Exception
{
    public ExcecaoSaldoInsuficiente(String message) 
    
    : base(message) //estou enviando a mensagem para a classe pai...
    {
        
    }
}