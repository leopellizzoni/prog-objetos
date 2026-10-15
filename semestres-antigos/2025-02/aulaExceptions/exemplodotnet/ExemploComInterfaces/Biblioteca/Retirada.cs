using System;

namespace ExemploComInterfaces.Biblioteca;

public class Retirada
{
    public Emprestimo Retirar(ILivro livro, IUsuario usuario)
    {
        Emprestimo emprestimo = new Emprestimo();
        DateTime hoje = DateTime.Now;

        //Tanto faz qual o tipo de usuario (prof ou aluno)
        //cada qual chama a quantidade liberada pra si de dias que pdoe ficar com o livro
        //pelo .DiasLiberado
        emprestimo.QuandoDevolver = hoje.AddDays(usuario.DiasLiberado());
        emprestimo.Livro = livro;
        emprestimo.Usuario = usuario;
        
        return emprestimo;
    }

}
