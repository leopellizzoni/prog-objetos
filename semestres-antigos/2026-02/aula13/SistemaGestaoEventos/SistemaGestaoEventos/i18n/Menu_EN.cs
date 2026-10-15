using System;

namespace SistemaGestaoEventos;

public class Menu_EN : IMenu
{
    public string CadastrarLocal()
    {
        return "Register Venue";
    }

    public string CadastrarParticipante()
    {
        return "Register Participant";
    }

    public Idioma ObterIdioma()
    {
        return Idioma.Ingles;
    }
}
