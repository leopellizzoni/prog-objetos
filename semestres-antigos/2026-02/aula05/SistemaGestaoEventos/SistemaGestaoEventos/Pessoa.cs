using System;

namespace SistemaGestaoEventos;

public class Pessoa : EntidadeComId
{
    public String Nome { get; set; }

    public String Telefone { get; set; }

    public String Email { get; set; }

    public String CPF {get;set;}
}
