using System;

namespace prova_1_26_4;

public abstract class Pessoa
{
    public Pessoa(string nome, string telefone, string endereco)
    {
        Nome = nome;
        Telefone = telefone;
        Endereco = endereco;
    }

    public String Nome { get; set; }

    public String Telefone { get; set; }
    
    public String Endereco { get; set; }
}
