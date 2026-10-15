using System;

namespace ConsoleAppAula01;




public class Pessoa
{
    //construtor
    public Pessoa(string nome, string sobrenome, int idade)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Idade = idade;
    }

    //propriedades
    private String nome;
    public String Nome 
    { 
        get
        {
            return nome;
        }
        set
        {
            if (value != "")
            {
                nome = value;
            } 
        } 
    }

    public String Sobrenome { get; set; }
    public int Idade { get; set; }
    public String CPF { get; set; }

    public bool APessoaEhIgual(Pessoa outraPessoa)
    {
        if (CPF == outraPessoa.CPF)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Igual_NaoFazer(Pessoa primeiraPessoa, Pessoa outraPessoa)
    {
        if (primeiraPessoa.Nome == outraPessoa.Nome &&
        primeiraPessoa.Sobrenome == outraPessoa.Sobrenome &&
        primeiraPessoa.Idade == outraPessoa.Idade)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool EhMaiorDeIdade()
    {
        if (Idade >= 18)
        {
            return true;
        }
        return false;
    }
}
