using System;

namespace ConsoleAppAula01;

public class CargoInfo
{
    public CargoInfo()
    {
        Representante = new Conselho();
    }

    public int Codigo {get;set;}

    public String Descricao {get;set;}

    public decimal PisoSalarial {get;set;}

    public Conselho Representante {get;set;}

    public String QuemEh()
    {
        return $"{ Codigo } - {Descricao}";
    }
}
