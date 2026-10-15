using System;

namespace prova_1_26_4;

public class Supervisor : Pessoa
{
    public Supervisor(string nome, string telefone, String endereco, String matricula) : base(nome, telefone, endereco)
    {
        NumeroMatricula = matricula;
    }

    public String NumeroMatricula { get; set; }
}