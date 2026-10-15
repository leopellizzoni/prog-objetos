using System.Xml;
using TratamentoPIX;
using TratamentoPIX.Excecoes;

Console.WriteLine("Hello, World!");

GerenciadorDoPIX gerPix = new GerenciadorDoPIX(10000, 900);

try
{
    System.Console.WriteLine("Transferencia dos 10");
    System.Console.WriteLine(gerPix.Transferir(10));
    System.Console.WriteLine("Transferencia dos 90000");
    System.Console.WriteLine(gerPix.Transferir(90000)); //linha que gera o erro
    //daqui em para baixo nao executa mais nada DENTRO desse try
    Console.WriteLine("Processamentos feitos com sucesso");
}
catch (ExcecaoSaldoInsuficiente exSaldo) //*.ExcecaoSaldoInsuficiente
{
    Console.WriteLine("---VIA ExcecaoSaldoInsuficiente");
    Console.WriteLine("-----------------");
    System.Console.WriteLine("***********************");
    Console.WriteLine(exSaldo.Message);
    System.Console.WriteLine("pilha de execucacao: ");
    System.Console.WriteLine(exSaldo.StackTrace);
    System.Console.WriteLine("***********************");
     Console.WriteLine("-----------------");
}
catch (ExcecaoLimiteUltrapassou exLimite) //*.ExcecaoLimiteUltrapassou
{
    Console.WriteLine("---VIA ExcecaoLimiteUltrapassou");
    //System.Console.WriteLine(exLimite.Message);
    System.Console.WriteLine("Oi, amigo.. hoje infelizmente o limite das transf. foi atingido. Tente amanha ou entre em contato.");
}
catch (Exception variavelEx) //*.*
{
    //apenas quando gera erro do tipo exception
    Console.WriteLine("---VIA Exception");
    Console.WriteLine(variavelEx.Message);
}
finally
{
    //sempre executa
    Console.WriteLine("Executou o Finally");
}

Console.WriteLine("THE END");