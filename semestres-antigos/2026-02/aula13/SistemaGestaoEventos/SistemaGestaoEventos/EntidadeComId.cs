using System;

namespace SistemaGestaoEventos;

public abstract class EntidadeComId
{
    public String Id { get; set; }

    public virtual string ObterDescricao()
    {
        return Id;
    }
}
