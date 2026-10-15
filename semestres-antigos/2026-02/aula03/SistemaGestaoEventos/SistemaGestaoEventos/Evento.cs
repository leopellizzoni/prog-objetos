using System;

namespace SistemaGestaoEventos;

public class Evento
{
    public DateTime Inicio { get; set; }

    public DateTime Fim { get; set; }

    public Local Local { get; set; }

    public Palestra[] Palestras { get; set; }
}
