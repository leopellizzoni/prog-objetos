package exemplocominterfaces;

public interface Funcionario {
    String getNome();
    void setNome(String novoNome);

    double getSalario();
    void setSalario(double novoSalario);

    String imprimirDescricao();

    String getTelefone();
}
