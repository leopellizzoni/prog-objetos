using System;

namespace ExemploComInterfaces;

//esses : equivalem ao implements do java
public class Cachorro : IAnimal
{
    public String Nome { get; set; }

    public string EmitirSom()
    {
        return "Au au";
    }
}