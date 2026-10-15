using System;

namespace TratamentoPIX.Excecoes;

//Java ExcecaoLimiteUltrapassou extends Exception

public class ExcecaoLimiteUltrapassou : Exception
{
    public ExcecaoLimiteUltrapassou(String msg) : base(msg)
    {
        
    }
}