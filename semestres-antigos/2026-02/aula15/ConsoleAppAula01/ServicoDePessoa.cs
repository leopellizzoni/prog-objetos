using System;

namespace ConsoleAppAula01;

public class ServicoDePessoa
{
    public bool Processar(Pessoa pessoa)
    {   
        if (!pessoa.EhMaiorDeIdade())
        {
           throw new ExcecaoDeRegraDoSistema("Ocorreu um erro. Não podemos processar uma pessoa menor de idade");
        }
        //----
        //----
        //----
        //----
        //----
        //----
        //----
        //----
        //----
        //----
        //----
        //----

        return true;
    }
}
