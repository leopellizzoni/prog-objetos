using System.Runtime.InteropServices;
using BibliotecaDotnet;

internal class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeBiblioteca gerenciador = new GerenciadorDeBiblioteca();
        gerenciador.Iniciar();
    }
}