using System;

namespace Biblioteca.Listas;

public interface IListaGenerica<MeuTipo> 
    where MeuTipo : ObjetoComId
{
    MeuTipo[] ObterTodos();
    void Adicionar(MeuTipo objeto);
    void Remover(MeuTipo objeto);
}
