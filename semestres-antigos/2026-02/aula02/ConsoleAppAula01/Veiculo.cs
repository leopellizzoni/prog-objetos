using System;

namespace ConsoleAppAula01;

public class Veiculo
{
    public Veiculo(String parametroPlaca)
    {
        Placa = parametroPlaca;
        Marca = "Não informada";
        Modelo = "Precisa definir";
    }

    public String Placa { get; private set; }

    public String Marca { get; set; }

    public String Modelo { get; set; }

    public String Descricao()
    {
        return $"Marca: { Marca } Modelo { Modelo } e Placa { Placa }";
    }
}
