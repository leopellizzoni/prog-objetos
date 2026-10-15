using System;

namespace ConsoleAppAula01;

public class RelatorioDePedidosParaTela : RelatorioDePedidos
{
    public override void RegistrarInformacao(string conteudo)
    {
        Console.WriteLine(conteudo);
    }
}
