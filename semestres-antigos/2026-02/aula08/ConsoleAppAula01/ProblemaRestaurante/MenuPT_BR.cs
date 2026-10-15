using System;

namespace ConsoleAppAula01.ProblemaRestaurante;

public class MenuPT_BR : IMenu
{
    public string Prato01()
    {
        return "Arroz e feijão";
    }

    public string Prato02()
    {
       return "Batata assada";
    }

    public string Prato03()
    {
       return "Lasanha";
    }

    public string SaudacaoInicial()
    {
        return "Olá, Bem Vindo :)";
    }
}