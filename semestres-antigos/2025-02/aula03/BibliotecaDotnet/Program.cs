using System.Runtime.InteropServices;
using BibliotecaDotnet;
using BibliotecaDotnet.Modelos;

internal class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeBiblioteca gerenciador = new GerenciadorDeBiblioteca();



        gerenciador.Iniciar();
    }
}