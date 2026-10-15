using System;

namespace ConsoleAppAula01;

public abstract class RelatorioDePedidos
{
    public abstract void RegistrarInformacao(String conteudo);

    public void ObterPorPeriodo(DateTime inicio, DateTime fim)
    {
        //Faz o processamento... busca na lista... achou os pedidos
        var pedido = new Pedido()
        {
            Id = 10,
            Nome = "Teste"
        };

        RegistrarInformacao("RELATORIO DOS PEDIDOS");
        RegistrarInformacao("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        RegistrarInformacao("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        RegistrarInformacao("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        RegistrarInformacao("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        RegistrarInformacao("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        RegistrarInformacao("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        RegistrarInformacao("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
        RegistrarInformacao("PEDIDO - " + pedido.Id + "  " + pedido.Nome);
    }
}
