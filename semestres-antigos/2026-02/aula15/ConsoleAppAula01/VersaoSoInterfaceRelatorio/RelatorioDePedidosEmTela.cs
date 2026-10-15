using System;

namespace ConsoleAppAula01.VersaoSoInterfaceRelatorio;

public class RelatorioDePedidosEmTela : IRelatorioDePedidos
{
    public void ObterPorPeriodo(DateTime inicio, DateTime fim)
    {
        //Faz o processamento... busca na lista... achou os pedidos
        var pedido = new Pedido()
        {
            Id = 10,
            Nome = "Teste"
        };

        Console.WriteLine("RELATORIO DOS PEDIDOS");
        Console.WriteLine("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        Console.WriteLine("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        Console.WriteLine("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        Console.WriteLine("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        Console.WriteLine("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        Console.WriteLine("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        Console.WriteLine("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        Console.WriteLine("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
    }
}
}
