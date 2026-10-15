using System;

namespace ConsoleAppAula01.ProblemaRestaurante;

public class MenuES : IMenu
{
    public string Prato01()
    {
        return "Arroz y frijoles";
    }

    public string Prato02()
    {
        return "Patatas asadas";
    }

    public string Prato03()
    {
       return "Lasaña";
    }

    public string SaudacaoInicial()
    {
        return "Hola, bienvenido :)";
    }
}