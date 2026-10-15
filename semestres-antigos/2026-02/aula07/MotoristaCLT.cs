using System;

namespace prova_1_26_4;

public class MotoristaCLT : Motorista
{
    public MotoristaCLT(string nome, string telefone, string endereco, DateTime primeiraHab) : base(nome, telefone, endereco, primeiraHab)
    {
    }

    public double SalarioMensal { get; set; }

    public Supervisor ResponsavelDireto { get; set; }
}