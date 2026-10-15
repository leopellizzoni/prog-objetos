using System;

namespace ConsoleAppAula01;

public class RelatorioDePedidoParaArquivo : RelatorioDePedidos
{
    private String _nomeDoArquivo;

    public RelatorioDePedidoParaArquivo(String arquivo)
    {
        _nomeDoArquivo = arquivo;
    }

    public override void RegistrarInformacao(string conteudo)
    {
        File.WriteAllText(_nomeDoArquivo, conteudo);
    }
}
