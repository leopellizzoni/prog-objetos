namespace Biblioteca;

public class Pessoa : ObjetoComId
{
    public String Nome {get;set;}

    public String Sobrenome {get;set;}

    public override string ToString()
    {
        return $"{Nome} {Sobrenome}";
    }
}
