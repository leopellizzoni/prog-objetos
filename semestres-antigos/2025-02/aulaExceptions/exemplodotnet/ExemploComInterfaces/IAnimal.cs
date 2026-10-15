using System;
//equivale ao #include <stdio.h> por exemplo ou ao import do java

namespace ExemploComInterfaces;

public interface IAnimal
{
    String Nome { get; set; }
    
    String EmitirSom();
}
