public class App {
    static Cliente[] todosClientes = new Cliente[0];

    public static void main(String[] args) throws Exception {
        
        todosClientes = adicionarCliente(new Cliente(1, "Leonardo"));
        todosClientes = adicionarCliente(new Cliente(2, "asdasdasd"));
        todosClientes = adicionarCliente(new Cliente(3, "Joao"));
        
        System.out.println("TODOS AGORA");
        for (var item : todosClientes) {
            System.out.println(item);
        }

        todosClientes = removerCliente(new Cliente(2, "asdasdasd"));
        System.out.println("DEPOIS DE REMOVER");
        for (var item : todosClientes) {
            System.out.println(item);
        }

    }

    static Cliente[] adicionarCliente(Cliente cliente){
        int i = 0;
        Cliente[] novo = new Cliente[todosClientes.length + 1];
        for (i = 0; i < todosClientes.length; i++) {
            novo[i] = todosClientes[i];
        }

        novo[novo.length - 1] = cliente;

        return novo;
    }

    static Cliente[] removerCliente(Cliente cliente){
        boolean existe = false;

        for (int i = 0; i < todosClientes.length; i++) {
            if (todosClientes[i].getId() == cliente.getId()){
                existe = true;
            }
        }
        if (existe == true){
            Cliente[] novo = new Cliente[todosClientes.length - 1];
            int contNovo = 0;
            for (int i = 0; i < todosClientes.length; i++) {
                if (todosClientes[i].getId() != cliente.getId()){
                    novo[contNovo] = todosClientes[i];
                    contNovo++;
                }
            }

            return novo;
        }

        return todosClientes;
    }
}
