using System;

namespace SistemaGestaoEventos;

public class MeuDado<QualAClasse> where QualAClasse : EntidadeComId
{
    private QualAClasse[] todasAsInformacoes;

    public MeuDado()
    {
        todasAsInformacoes = [];
    }

    public QualAClasse[] Adicionar(QualAClasse novo)
    {
        QualAClasse[] novoVetor = new QualAClasse[todasAsInformacoes.Length + 1];

        int cont;

        for (cont = 0; cont < todasAsInformacoes.Length; cont++)
        {
            novoVetor[cont] = todasAsInformacoes[cont];
        }

        novoVetor[novoVetor.Length - 1] = novo;

        return novoVetor;
    }

    public QualAClasse Obter(int index)
    {
        return todasAsInformacoes[index];
    }

    public void Listar() 
    {
        for(int i = 0; i <= todasAsInformacoes.Count(); i++)
        {
            Console.WriteLine($"{i + 1}) {todasAsInformacoes[i].ObterDescricao()}");
        }
    }

}
