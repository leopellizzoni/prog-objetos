
namespace aula3prot;

class Program
{
    static Cliente[] todosClientes = [];

    static void Main(string[] args)
    {
        todosClientes = AdicionarCliente(new Cliente() { Id = 1, Nome = "Leonardo" });
        todosClientes = AdicionarCliente(new Cliente() { Id = 2, Nome = "asd" });
        todosClientes = AdicionarCliente(new Cliente() { Id = 3, Nome = "44sdlasldkalsdklasdk" });

        foreach (var item in todosClientes)
        {
            System.Console.WriteLine(item);
        }


        todosClientes = RemoverCliente(new Cliente() { Id = 1, Nome = "Leonardo" });
        
        System.Console.WriteLine("DEPOIS DE DELETAR");
        foreach (var item in todosClientes)
        {
            System.Console.WriteLine(item);
        }
    }

    static Cliente[] AdicionarCliente(Cliente cliente)
    {
        Cliente[] novoVetor = new Cliente[todosClientes.Length + 1];

        int cont;

        for (cont = 0; cont < todosClientes.Length; cont++)
        {
            novoVetor[cont] = todosClientes[cont];
        }

        novoVetor[novoVetor.Length - 1] = cliente;

        return novoVetor;
    }

    static Cliente[] RemoverCliente(Cliente cliente)
    {
        bool existe = false;
        int i = 0;

        for (i = 0; i < todosClientes.Length; i++)
        {
            if (todosClientes[i].Id == cliente.Id)
            {
                existe = true;
                break;
            }
        }

        if (existe == true)
        {
            Cliente[] novoVetor = new Cliente[todosClientes.Length - 1];

            int contNovoVetor = 0;
            for (i = 0; i < todosClientes.Length; i++)
            {
                if (todosClientes[i].Id != cliente.Id)
                {
                    novoVetor[contNovoVetor] = todosClientes[i];
                    contNovoVetor++;
                }
            }

            return novoVetor;
        }

        return todosClientes;
    }
}