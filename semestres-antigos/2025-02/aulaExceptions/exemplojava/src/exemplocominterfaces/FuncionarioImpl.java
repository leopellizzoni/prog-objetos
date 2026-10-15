package exemplocominterfaces;

public class FuncionarioImpl implements Funcionario {
    private String nome;
    private double salario;

    @Override
    public String getNome() {
        return nome;
    }

    @Override
    public void setNome(String novoNome) {
        nome = novoNome;    
    }

    @Override
    public double getSalario() {
        return salario;
    }

    @Override
    public void setSalario(double novoSalario) {
        salario = novoSalario;
    }

    @Override
    public String imprimirDescricao() {
        return getNome() + " " + getSalario();
    }

    @Override
    public String getTelefone() {
        return "TELEFONE";
    }
}
