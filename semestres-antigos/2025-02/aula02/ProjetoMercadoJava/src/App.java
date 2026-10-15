public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Programa do Mercado");

        Produto leite = new Produto();
        leite.setCodigo(1);
        leite.setDescricao("leite Santa Clara");
        leite.setValor(4.67);

        Produto cafe = new Produto();
        cafe.setCodigo(2);
        cafe.setDescricao("Cafe Bom Jesus");
        cafe.setValor(24.99);

        leite.imprimirDescricao();
        cafe.imprimirDescricao();

    }
}
