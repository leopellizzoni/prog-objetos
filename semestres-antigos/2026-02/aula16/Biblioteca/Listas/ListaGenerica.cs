using System;

namespace Biblioteca.Listas;

public class ListaGenerica<MeuTipo> : IListaGenerica<MeuTipo>
    where MeuTipo : ObjetoComId
{   
    List<MeuTipo> meusDadosInterno;

    public MeuTipo[] ObterTodos()
    {
        return meusDadosInterno.ToArray();
    }

    public void Adicionar(MeuTipo objeto)
    {
        meusDadosInterno.Add(objeto);
    }

    public void Remover(MeuTipo objeto)
    {
        meusDadosInterno.Remove(objeto);
    }
}
