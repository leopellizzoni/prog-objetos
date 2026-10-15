using System;

namespace prova_1_26_4;

public class MotoristaAutonomo : Motorista
{
    public MotoristaAutonomo(string nome, string telefone, string endereco, DateTime primeiraHab) : base(nome, telefone, endereco, primeiraHab)
    {
        
    }

    public double ValorPorKmRodado { get; set; }
}
