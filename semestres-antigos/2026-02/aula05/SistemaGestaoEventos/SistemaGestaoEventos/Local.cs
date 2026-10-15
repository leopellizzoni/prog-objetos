using System;

namespace SistemaGestaoEventos;

public class Local : EntidadeComId
{
    public String Nome { get; set; }

    public String Endereco { get; set; }

    public int Capacidade { get; set; }

    public override string ObterDescricao()
    {
        return $"{Nome} com capacidade para {Capacidade} pessoas em {Endereco}";
    }
}