using System.Runtime.InteropServices;
using BibliotecaDotnet;
using BibliotecaDotnet.Modelos;
using BibliotecaDotnet.Modelos.Pessoas;

internal class Program
{
    static void Main(string[] args)
    {
        // GerenciadorDeBiblioteca gerenciador = new GerenciadorDeBiblioteca();
        // gerenciador.Iniciar();

        PessoaFisica cidadao = new PessoaFisica();
        PessoaJuridica empresa = new PessoaJuridica();
        Usuario usu = new Usuario(1010, "Teste de Usuario", "(54)99999999");

        cidadao.Id = 1;
        cidadao.Nome = "Leonardo";
        cidadao.NomeDaMae = "Mae do Leonardo";
        cidadao.CPF = "C222222222";
        cidadao.MetodoPublico();

        empresa.Id = 2;
        empresa.Nome = "Empresa do Leonardo";
        empresa.NomeFantasia = "Fantasia";
        empresa.MetodoPublico();

        Console.WriteLine("Cidadao: " + cidadao.TesteDeSobreescrita());
        Console.WriteLine("Empresa: " + empresa.TesteDeSobreescrita());
        Console.WriteLine("Usuario: " + usu.TesteDeSobreescrita());


        Onibus onibus = new Onibus("placa do outro onibus");
        Onibus onibusMarcopolo = new Onibus("Marcopolo", "placa");

        System.Console.WriteLine(onibus.ObterDescricaoDoVeiculo());;
    }
}