using System;

namespace BibliotecaDotnet.Modelos.Pessoas;

//Versao Java public class PessoaJuridica extends Pessoa
public class PessoaJuridica : Pessoa
{
    public String CNPJ {get;set;}

    public String NomeFantasia {get;set;}

    public override string TesteDeSobreescrita()
    {
        return "Veio da classe Pessoa Juridica - que é uma classe filho";
    }
}
