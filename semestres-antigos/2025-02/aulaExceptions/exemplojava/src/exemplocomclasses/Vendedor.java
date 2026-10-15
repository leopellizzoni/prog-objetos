package exemplocomclasses;
public class Vendedor extends Funcionario {
    private Gerente chefe;

    public Gerente getChefe() {
        return chefe;
    }

    public void setChefe(Gerente chefe) {
        this.chefe = chefe;
    }
}
