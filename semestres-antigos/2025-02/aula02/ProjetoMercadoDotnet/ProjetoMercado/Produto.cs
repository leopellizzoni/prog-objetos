namespace ProjetoMercado;

public class Produto
{
    public Produto(int codigoDoConstrutor)
    {
        Codigo = codigoDoConstrutor;
    }

    int codigoInterno;
    public int Codigo
    {
        get
        {
            return codigoInterno;
        }
        set
        {
            if (value != 5)
            {
                codigoInterno = value;
            }
        }
    }
    public String Nome;
    public double Valor;
    public DateTime Validade;
    public int CodigoDeBarra;

    public void ImprimirDescricao()
    {
        Console.WriteLine("Código: " + Codigo +
        " Nome: " + Nome +
        " Valor: " + Valor);
    }
}
