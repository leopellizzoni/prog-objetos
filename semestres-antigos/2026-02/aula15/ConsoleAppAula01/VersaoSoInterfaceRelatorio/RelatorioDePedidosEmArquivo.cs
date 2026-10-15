using System;

namespace ConsoleAppAula01.VersaoSoInterfaceRelatorio;

public class RelatorioDePedidosEmArquivo : IRelatorioDePedidos
{
    public void ObterPorPeriodo(DateTime inicio, DateTime fim)
    {
        //Faz o processamento... busca na lista... achou os pedidos
        var pedido = new Pedido()
        {
            Id = 10,
            Nome = "Teste"
        };

        File.WriteAllText("meu-arquivo.txt", "RELATORIO DOS PEDIDOS");
        File.WriteAllText("meu-arquivo.txt", "PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        File.WriteAllText("meu-arquivo.txt", "PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        File.WriteAllText("meu-arquivo.txt", "PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        File.WriteAllText("meu-arquivo.txt", "PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        File.WriteAllText("meu-arquivo.txt", "PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        File.WriteAllText("meu-arquivo.txt", "PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        File.WriteAllText("meu-arquivo.txt", "PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        File.WriteAllText("meu-arquivo.txt", "PEDIDO - " + pedido.Id + "  " + pedido.Nome);
    }
}
