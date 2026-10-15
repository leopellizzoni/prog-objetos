using System;

namespace ConsoleAppAula01.VersaoSoInterfaceRelatorio;

public interface IRelatorioDePedidos
{
    void ObterPorPeriodo(DateTime inicio, DateTime fim);
}
