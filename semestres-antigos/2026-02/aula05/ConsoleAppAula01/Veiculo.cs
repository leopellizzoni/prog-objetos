using System;

namespace ConsoleAppAula01;

public abstract class Veiculo
{
    public Veiculo()
    {
        Placa = "Não Informada";
        Marca = "Não informada";
        Modelo = "Precisa definir";
    }

    public String Placa { get; set; }

    public String Marca { get; set; }

    public String Modelo { get; set; }

    protected String DescricaoDoVeiculo {get;set;}

    public abstract String MinhaDescricao();
    
    public String Descricao()
    {
        return $"{ MinhaDescricao() } |  Marca: { Marca } Modelo { Modelo } e Placa { Placa }";
    }
}
