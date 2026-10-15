using Biblioteca;
using Biblioteca.Listas;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var p1 = new Pessoa(){ Nome = "Maria", Sobrenome = "Antunes"};
        var p2 = new Pessoa(){ Nome = "Jose", Sobrenome = "Sobrenome Jose"};
        var p3 = new Pessoa(){ Nome = "Joao", Sobrenome = "Sobrenome Joao"};
        var p4 = new Pessoa(){ Nome = "Criatura", Sobrenome = "Sobrenome Criatura"};
        var p5 = new Pessoa(){ Nome = "Maria", Sobrenome = "Silva"};

        List<Pessoa> pessoas = new List<Pessoa>(); //Pessoa[] pessoas;

        pessoas.Add(p1);
        pessoas.Add(p2);
        pessoas.Add(p3);
        pessoas.Add(p4);
        pessoas.Add(p5);

        for(int i = 0; i < pessoas.Count; i++)
        {
            Console.WriteLine(pessoas[i].Nome + "  " + pessoas[i].Sobrenome);
        }

        var mariasAutomatico = pessoas.Where(p => p.Nome == "Maria");

        var listaDasMariasManual = new List<Pessoa>();
        foreach(Pessoa p in pessoas)
        {
            if (p.Nome == "Maria")
            {
                listaDasMariasManual.Add(p);
            }
        }
        Console.WriteLine("via for manual");
        foreach(Pessoa p in listaDasMariasManual)
        {
            Console.WriteLine(p.ToString());
        }

        Console.WriteLine("via Metodo Where");
        foreach(Pessoa p in mariasAutomatico)
        {
            Console.WriteLine(p.ToString());
        }

        ListaGenerica<Pessoa> lstGenerica = new ListaGenerica<Pessoa>();
        lstGenerica.Adicionar(p1);
        lstGenerica.Adicionar(p2);
        lstGenerica.Adicionar(p3);
        lstGenerica.Adicionar(p4);
        
        IListaDePessoa listaViaInterface;
        Console.WriteLine("1 - Lista com Array");
        Console.WriteLine("2 - Lista com List da linguagem");
        int tipoArmazenamento = int.Parse(Console.ReadLine());
        if (tipoArmazenamento == 1)
        {
            listaViaInterface = new ListaDePessoa()
        }
        else
        {
            listaViaInterface = new ListaDePessoasComVetor();
        }

        listaViaInterface.Adicionar(p1);
        listaViaInterface.Adicionar(p2);
        listaViaInterface.Adicionar(p3);
        listaViaInterface.Adicionar(p4);
    }
}