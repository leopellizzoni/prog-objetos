using System.Net.NetworkInformation;
using SistemaGestaoEventos;

internal class Program
{
    private static Local CadastrarLocal()
    {
        Console.WriteLine("Informe o nome do local: ");
        var nomeLocal = Console.ReadLine();
        Console.WriteLine("Informe o endereco do local: ");
        var enderecoLocal = Console.ReadLine();
        Console.WriteLine("Informe a capacidade");
        var capacidade = Console.ReadLine();
        Local local = new Local();
        local.Nome = nomeLocal;
        local.Endereco = enderecoLocal;
        local.Capacidade = int.Parse(capacidade);
        return local;
    }

    private static Palestrante CadastrarPalestrante()
    {
        Console.WriteLine("Informe o nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Informe o telefone: ");
        var telefone = Console.ReadLine();
        System.Console.WriteLine("Informe o email: ");
        var email = Console.ReadLine();
        System.Console.WriteLine("Informe o Valor Hora em R$: ");
        var valorHora = Console.ReadLine();
        
        Palestrante palestrante = new Palestrante();
        palestrante.Id = Guid.NewGuid().ToString();
        palestrante.Nome = nome;
        palestrante.Email = email;
        palestrante.Telefone = telefone;
        palestrante.ValorHora = decimal.Parse(valorHora);

        return palestrante;
    }

    static Palestrante[] AdicionarPalestrante(Palestrante cliente)
    {
        Palestrante[] novoVetor = new Palestrante[todosPalestrantes.Length + 1];

        int cont;

        for (cont = 0; cont < todosPalestrantes.Length; cont++)
        {
            novoVetor[cont] = todosPalestrantes[cont];
        }

        novoVetor[novoVetor.Length - 1] = cliente;

        return novoVetor;
    }
    static Participante[] todosParticipantes = [];
    static Palestrante[] todosPalestrantes = [];

    private static void Main(string[] args)
    {
        Local localDoEvento;
        Evento evento;
        Palestra palestra;

        Console.WriteLine("Sistema de Gestão de Eventos");
        int opcao = 0;
        do
        {
            Console.WriteLine("10 - Cadastrar Local");
            Console.WriteLine("20 - Cadastrar Participante");
            Console.WriteLine("30 - Cadastrar Palestrante");
            Console.WriteLine("31 - Listar todos os Palestrantes");
            Console.WriteLine("99 - Sair do sistema");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 10)
            {
                localDoEvento = CadastrarLocal();
            }
            else if (opcao == 30)
            {
                //Pede para o usuario as informacoes e gera o objeto Palestrante
                var novoPalestrante = CadastrarPalestrante();
                //aqui esta adicionando no vetor de todosPalestrantes.
                todosPalestrantes = AdicionarPalestrante(novoPalestrante);
            }
            else if (opcao == 31)
            {
                foreach (var item in todosPalestrantes)
                {
                    Console.WriteLine($"{item.Nome} - {item.Email} - {item.Telefone}");
                }   
            }

        }while(opcao != 99);
    }
}