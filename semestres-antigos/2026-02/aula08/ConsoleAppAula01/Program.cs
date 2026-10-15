using ConsoleAppAula01;
using ConsoleAppAula01.ProblemaRestaurante;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite 1  para Português (PT-BR)");
        Console.WriteLine("Teclea el 2 para Español (ES)");

        int opMenu = int.Parse(Console.ReadLine());
        IMenu menu;

        if (opMenu == 1)
        {
            menu = new MenuPT_BR();
        }
        else
        {
            menu = new MenuES();
        }

        Console.WriteLine(menu.SaudacaoInicial());
        Console.WriteLine(menu.Prato01());
        Console.WriteLine(menu.Prato02());
        Console.WriteLine(menu.Prato03());
    }
}