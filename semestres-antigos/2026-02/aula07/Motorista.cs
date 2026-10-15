using System;

namespace prova_1_26_4;

public abstract class Motorista : Pessoa
{
    protected Motorista(string nome, string telefone, string endereco, DateTime primeiraHab) : base(nome, telefone, endereco)
    {
        PrimeiraHabilitacao = primeiraHab;
    }

    public DateTime PrimeiraHabilitacao { get; set; }
}