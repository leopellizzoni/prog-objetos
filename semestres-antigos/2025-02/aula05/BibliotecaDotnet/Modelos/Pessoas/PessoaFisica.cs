using System;

namespace BibliotecaDotnet.Modelos.Pessoas;

//Versao Java public class PessoaFisica extends Pessoa
//PessoaFisica possui uma herança (:) para a classe pessoa
public class PessoaFisica : Pessoa
{
    public PessoaFisica()
    {
        MetodoProtected();
    }
    public String CPF {get;set;}

     public String NomeDaMae {get;set;}

    public String NomeDoPai {get;set;}

    //@Override para a versao java..
    //Fizemos uma sobreescrita do metodo ObterDescricao porque pediram para 
    //na pessoa fisica acrescentar o cpf depois do nome
    //Como a classe pessoa nao tem o cpf fizemos aqui pelo override e porque 
    //o metodo na classe pai estava marcado com virtual.
    public override string ObterDescricao()
    {
        return base.ObterDescricao() + " CPF: " + CPF;
    }

    public override string TesteDeSobreescrita()
    {
        return "Veio da classe de PessoaFisica. Classe filho";
    }
}