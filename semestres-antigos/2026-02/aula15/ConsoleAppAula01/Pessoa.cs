using System;

namespace ConsoleAppAula01;




public class Pessoa
{
    //construtor
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

    public String PodeBeber()
    {
        if (EhMaiorDeIdade())
        {
            return $"{Nome}: Pode beber - desde que moderadamente";
        }
        else
        {
            return $"{Nome}: Não pode beber";
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
