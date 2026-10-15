using TratamentoPIX.Excecoes;

namespace TratamentoPIX;

public class GerenciadorDoPIX
{
    public GerenciadorDoPIX(double saldo, double limite)
    {
        Saldo = saldo;
        Limite = limite;
    }

    private double Saldo { get; set; }

    private double Limite { get; set; }

    public bool Transferir(double valor)
    {
        if (valor > Saldo)
        {
            //Antes nos tinhamos o throw new Exception("texto")
            throw new ExcecaoSaldoInsuficiente("Saldo insuficiente");
        }

        if (valor > Limite)
        {
            //Antes nos tinhamos o throw new Exception("texto")
            throw new ExcecaoLimiteUltrapassou($"Não podemos fazer o pix por causa do limite de {Limite} excedido");
        }

        return true;
    }
}
