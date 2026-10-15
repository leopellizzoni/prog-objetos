using System;
using BibliotecaDotnet.Modelos.Pessoas;

namespace BibliotecaDotnet.Modelos;

public class Usuario : Pessoa
{   
    //Construtor da classe usuário. É o que executa quando chamamos new Usuario informando os parametros id, nome e whatsapp
    //Podemos pensar no construtor como algo que transforma nossa classe (abstrata, que representa algo) para instancia na memoria do computador 
    //Esta instancia passa a representar alguma informação que remete a algo concreto do mundo real.
    public Usuario(int id, String nome, String whatsApp)
    {
        Id = id;
        Nome = nome;
        WhatsApp = whatsApp;
    }

    //Construtor da classe usuário. É o que executa quando chamamos new Usuario informando os parametros id, nome, email e whatsapp
    //Podemos pensar no construtor como algo que transforma nossa classe (abstrata, que representa algo) para instancia na memoria do computador 
    //Esta instancia passa a representar alguma informação que remete a algo concreto do mundo real.
    public Usuario(int id, String nome, String email, String whatsApp)
    {
        Id = id;
        Nome = nome;
        Email = email;
        WhatsApp = whatsApp;
    }

    public String Email { get; set; }

    public String WhatsApp {get;set;}
    
    public Livro UltimoLivroRetirado {get;set;}

    public override String ObterDescricao()
    {
        if (UltimoLivroRetirado != null)
        {
            return $"Id: {Id} Nome: {Nome} | Ultimo Livro Retirado {UltimoLivroRetirado.Titulo}";
        }

        return $"Id: {Id} Nome: {Nome} ";
    }

    //Exemplo com private e public
    public String ObterDescricaoPublica()
    {
        return ObterDescricao();
    }

    public override string TesteDeSobreescrita()
    {
        return "Veio da Classe Filho (USUARIO)";
    }
}
