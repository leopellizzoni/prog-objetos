public class Produto {
    private int codigo;
    private String descricao;
    private double valor;

    public int getCodigo() {
        return this.codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getDescricao() {
        return this.descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public double getValor() {
        return this.valor;
    }

    public void setValor(double valor) {
        this.valor = valor;
    }

    public void imprimirDescricao(){
        System.out.println("Codigo: " + getCodigo() + 
        " Descricao: " + getDescricao() + 
        " Valor: " + getValor());
    }
}
