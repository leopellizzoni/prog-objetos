using System;

namespace Biblioteca.Listas;

public class ListaGenericaComVetor<MeuTipo> 
    where MeuTipo : ObjetoComId
{   
    MeuTipo[] meusDadosInterno;

    public MeuTipo[] ObterTodos()
    {
        return meusDadosInterno;
    }

    public void Adicionar(MeuTipo objeto)
    {
        MeuTipo[] novoVetor = new MeuTipo[meusDadosInterno.Length + 1];

        int cont;

        for (cont = 0; cont < meusDadosInterno.Length; cont++)
        {
            novoVetor[cont] = meusDadosInterno[cont];
        }

        novoVetor[novoVetor.Length - 1] = objeto;

        meusDadosInterno = novoVetor;
    }

    public void Remover(MeuTipo objeto)
    {
        bool existe = false;
        int i = 0;

        for (i = 0; i < meusDadosInterno.Length; i++)
        {
            if (meusDadosInterno[i].Id == objeto.Id)
            {
                existe = true;
                break;
            }
        }

        if (existe == true)
        {
            MeuTipo[] novoVetor = new MeuTipo[meusDadosInterno.Length - 1];

            int contNovoVetor = 0;
            for (i = 0; i < meusDadosInterno.Length; i++)
            {
                if (meusDadosInterno[i].Id != objeto.Id)
                {
                    novoVetor[contNovoVetor] = meusDadosInterno[i];
                    contNovoVetor++;
                }
            }

            meusDadosInterno = novoVetor;
        }
    }
}
