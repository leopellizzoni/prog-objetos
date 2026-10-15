using System;

namespace Biblioteca.Modelos;

public abstract class Pessoa : ObjetoComId
{
    public Pessoa()
    {
        MetodoPrivado();
    }

    public String Nome {get;set;} 

    //Aparece para todas as variavies instanciadas
    public String MetodoPublico()
    {
        return "";
    }
    
    //acessado da propria classe e das classes filhas.
    //Classe filha é quem herda de uma outra classe
    protected String MetodoProtected()
    {
        return "";
    }

    //uso especifico da classe atual. nenhum outro permite acesso.
    private String MetodoPrivado()
    {
        return "Gerada na classe pai de pessoa: " + Nome;
    }

    //Usamos o virtual para permitir que alguma das classes filhas alterem o 
    //comportamento do método. No caso o retorno.
    public virtual String ObterDescricao()
    {
        return "Nome: " + Nome;
    }

    public virtual String TesteDeSobreescrita()
    {
        return "Veio da classe pai (Pessoa)";
    }
}
