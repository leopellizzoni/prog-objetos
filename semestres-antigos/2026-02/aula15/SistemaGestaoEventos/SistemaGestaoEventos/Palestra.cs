using System;

namespace SistemaGestaoEventos;

public class Palestra : EntidadeComId
{
    public String Titulo { get; set; }

    public Participante[] Participantes { get; set; }

    public Palestrante[] Palestrantes { get; set; }
}
