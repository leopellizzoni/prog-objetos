using System;

namespace ConsoleAppAula01;

public class Moto : Veiculo //Java Moto extends Veiculo
{
    public Moto()
    {
        DescricaoDoVeiculo = "Uma Moto";
    }
    public int CC {get;set;}

    public override string MinhaDescricao()
    {
        return "Uma Moto";
    }
}