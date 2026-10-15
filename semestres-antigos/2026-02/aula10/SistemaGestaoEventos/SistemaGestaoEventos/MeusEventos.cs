using System;

namespace SistemaGestaoEventos;

public class MeusEventos : MeuDado<Evento>
{
    //nao existe mais aqui porque foi para a classe pai (MeuDado)
//     private Evento[] todosEventos;

//     public MeusEventos()
//     {
//         todosEventos = [];
//     }

//     public Evento[] Adicionar(Evento novo)
//     {
//         Evento[] novoVetor = new Evento[todosEventos.Length + 1];

//         int cont;

//         for (cont = 0; cont < todosEventos.Length; cont++)
//         {
//             novoVetor[cont] = todosEventos[cont];
//         }

//         novoVetor[novoVetor.Length - 1] = novo;

//         return novoVetor;
//     }

//     public Evento Obter(int index)
//     {
//         return todosEventos[index];
//     }

//     public void Listar() 
//     {
//         for(int i = 0; i <= todosEventos.Count(); i++)
//         {
//             Console.WriteLine($"{i + 1}) {todosEventos[i].ObterDescricao()}");
//         }
//     }
}
