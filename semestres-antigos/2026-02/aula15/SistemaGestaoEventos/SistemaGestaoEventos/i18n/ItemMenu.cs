public class ItemMenu
{
    public String Codigo {get;set;}

    public double Valor {get;set;}

    public Texto[] Descricoes {get;set;}

    public String ObterDescricao(Idioma idioma)
    {
        String descricaoCompleta = $"{Codigo} - ";        

        for(int cont = 0; cont < Descricoes.Length; cont++)
        {
            if (Descricoes[cont].Idioma == idioma)
            {
                descricaoCompleta = descricaoCompleta + Descricoes[cont].Conteudo; 
                break;
            }
        }

        descricaoCompleta += $" - {Valor}";

        return descricaoCompleta;
    }
}