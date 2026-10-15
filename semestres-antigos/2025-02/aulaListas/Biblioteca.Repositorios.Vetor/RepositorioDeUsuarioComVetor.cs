using System;
using System.Reflection.PortableExecutable;
using Biblioteca.Modelos;

namespace Biblioteca.Repositorios.Vetor;

public class RepositorioDeUsuarioComVetor
{
    private Usuario[] todosUsuarios = new Usuario[1];

    public RepositorioDeUsuarioComVetor()
    {
        Usuario usuario = new Usuario("Leonardo", "lpellizzoni@ucs.br", "+555411111111");
        usuario.Id = 1;
        todosUsuarios[0] = usuario;
    }

    public Usuario[] ObterTodos()
    {
        return todosUsuarios.ToArray();
    }

    public void Adicionar(Usuario usuarioNovo)
    {
        int novoId = todosUsuarios.Length + 1;

        Usuario[] novosUsuarios = new Usuario[todosUsuarios.Length + 1];

        for (int i = 0; i < todosUsuarios.Length; i++)
        {
            novosUsuarios[i] = todosUsuarios[i];
        }

        novosUsuarios[novosUsuarios.Length - 1] = usuarioNovo;
        
        todosUsuarios = novosUsuarios;
    }
}