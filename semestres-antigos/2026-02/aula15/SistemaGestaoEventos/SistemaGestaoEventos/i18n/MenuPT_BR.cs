namespace SistemaGestaoEventos.i18n;
public class MenuPT_BR : IMenu
{
    public String CadastrarLocal()
    {
        return "Cadastrar Local";
    }

    public String CadastrarParticipante()
    {
        return "Cadastrar Participante";
    }

    public Idioma ObterIdioma()
    {
        return Idioma.Portugues;
    }
}