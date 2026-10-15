package exemplocominterfaces;

public class VendedorImpl extends FuncionarioImpl implements Vendedor {
    @Override
    public String getMetodoSoNoVendor() {
        return "Metodo do vendedor";
    }
}
