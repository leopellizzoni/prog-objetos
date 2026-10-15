import exemplocominterfaces.*;

public class App {
    public static void main(String[] args) throws Exception {
        
        //Tipo da variavel = Funcionario (interface)
        //Instancia da variavel = Vendedor (classe)
        //Só consigo chamar e usar os metodos que estao na interface

        Vendedor v = new VendedorImpl();
        v.setNome("nome do funcionar");
        v.setSalario(2000);
        v.imprimirDescricao();
        v.getTelefone();
        
        v.getMetodoSoNoVendor(); //apesar de existir se for da interface ou classe vendedor.


        System.out.println("Hello, World!");
    }
}
