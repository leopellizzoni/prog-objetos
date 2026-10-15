using System;

namespace SistemaGestaoEventos;

public class Local : EntidadeComId
{
    public String Nome { get; set; }

    public String Endereco { get; set; }

    public int Capacidade { get; set; }
}