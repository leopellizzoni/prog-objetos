using System.Security.Cryptography.X509Certificates;
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

    public static Evento CadastrarEvento()
    {
        Console.WriteLine("Informe a data de inicio (Formato DD/MM/YYYY)");
        var inicio = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Informe a data de fim (Formato DD/MM/YYYY)");
        var fim = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Escolha um local informando o número dele");
        
        for(int i = 0; i <= todosLocais.Count(); i++)
        {
            Console.WriteLine($"{i + 1}) {todosLocais[i].ObterDescricao()}");
        }
        int localEscolhido = int.Parse(Console.ReadLine());

        var novoEvento = new Evento();

        novoEvento.Id = Guid.NewGuid().ToString();
        novoEvento.Inicio = inicio;
        novoEvento.Fim = fim;
        novoEvento.Local = todosLocais[localEscolhido - 1]; //porque iniciou do 1 

        return novoEvento;
    }

    static MeuTipo[] AdicionarNoVetor<MeuTipo>(MeuTipo novo, MeuTipo[] existentes)
    {
        MeuTipo[] novoVetor = new MeuTipo[existentes.Length + 1];

        int cont;

        for (cont = 0; cont < existentes.Length; cont++)
        {
            novoVetor[cont] = existentes[cont];
        }

        novoVetor[novoVetor.Length - 1] = novo;

        return novoVetor;
    }


    // static Palestrante[] AdicionarPalestrante(Palestrante cliente)
    // {
    //     Palestrante[] novoVetor = new Palestrante[todosPalestrantes.Length + 1];

    //     int cont;

    //     for (cont = 0; cont < todosPalestrantes.Length; cont++)
    //     {
    //         novoVetor[cont] = todosPalestrantes[cont];
    //     }

    //     novoVetor[novoVetor.Length - 1] = cliente;

    //     return novoVetor;
    // }

    // static Local[] AdicionarLocal(Local cliente)
    // {
    //     Local[] novoVetor = new Local[todosLocais.Length + 1];

    //     int cont;

    //     for (cont = 0; cont < todosLocais.Length; cont++)
    //     {
    //         novoVetor[cont] = todosLocais[cont];
    //     }

    //     novoVetor[novoVetor.Length - 1] = cliente;

    //     return novoVetor;
    // }

    // static Evento[] AdicionarEvento(Evento evento)
    // {
    //     Evento[] novoVetor = new Evento[todosEventos.Length + 1];

    //     int cont;

    //     for (cont = 0; cont < todosEventos.Length; cont++)
    //     {
    //         novoVetor[cont] = todosEventos[cont];
    //     }

    //     novoVetor[novoVetor.Length - 1] = evento;

    //     return novoVetor;
    // }

    static void Listar<TipoDoObjeto>(TipoDoObjeto[] meuVetor) where TipoDoObjeto : EntidadeComId
    {
        for(int i = 0; i <= meuVetor.Count(); i++)
        {
            Console.WriteLine($"{i + 1}) {meuVetor[i].ObterDescricao()}");
        }
    }

    static Participante[] todosParticipantes = [];
    static Palestrante[] todosPalestrantes = [];
    static Local[] todosLocais = [];
    static Evento[] todosEventos = [];

    private static void Main(string[] args)
    {
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
            Console.WriteLine("40 - Cadastrar Evento");
            Console.WriteLine("99 - Sair do sistema");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 10)
            {
                var localNovo = CadastrarLocal();
                //todosLocais = AdicionarLocal(localNovo);
                todosLocais = AdicionarNoVetor<Local>(localNovo, todosLocais);
            }
            else if (opcao == 30)
            {
                //Pede para o usuario as informacoes e gera o objeto Palestrante
                var novoPalestrante = CadastrarPalestrante();
                //aqui esta adicionando no vetor de todosPalestrantes.
                //todosPalestrantes = AdicionarPalestrante(novoPalestrante);
                todosPalestrantes = AdicionarNoVetor<Palestrante>(novoPalestrante, todosPalestrantes);
            }
            else if (opcao == 31)
            {
                //Refatorado para usar o Listar genérico ao invés de manter 1 para cada tipo de classe
                // foreach (var item in todosPalestrantes)
                // {
                //     Console.WriteLine($"{item.Nome} - {item.Email} - {item.Telefone}");
                // }   

                Listar<Palestrante>(todosPalestrantes);
            }
            else if (opcao == 40)
            {
                //todosEventos = AdicionarEvento(CadastrarEvento());
                todosEventos = AdicionarNoVetor<Evento>(CadastrarEvento(), todosEventos);
            }

        }while(opcao != 99);
    }
}