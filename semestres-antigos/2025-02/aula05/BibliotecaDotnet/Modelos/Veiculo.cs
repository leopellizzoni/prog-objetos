using System;

namespace BibliotecaDotnet.Modelos;

public abstract class Veiculo
{
    public String Marca;
    public String Placa;

    public virtual String ObterDescricaoDoVeiculo()
    {
        return Marca + " " + Placa;
    }
}

public class Onibus : Veiculo //se fosse java era extends no lugar dos :
{
    public int Andares;

    public Onibus(String placa)
    {
        this.Placa = placa;
    }

    public Onibus(String marca, String placa)
    {
        this.Marca = marca;
        this.Placa = placa;
    }

    public override string ObterDescricaoDoVeiculo()
    {
        return "Onibus: " + base.ObterDescricaoDoVeiculo();;
    }


}