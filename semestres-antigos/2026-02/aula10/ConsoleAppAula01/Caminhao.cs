using System;

namespace ConsoleAppAula01;

public class Caminhao : Veiculo
{
    public Caminhao()
    {
        DescricaoDoVeiculo = "Caminhão";
    }
    public int PesoTotalParaTransporte {get;set;}

    public override string MinhaDescricao()
    {
        return "Caminhão";
    }
}
