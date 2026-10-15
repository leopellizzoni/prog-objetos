using ConsoleAppAula01;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario joao = new Funcionario("João", "Eng. de Software", 25000);
        Console.WriteLine("O salario liquido do joao é: " + joao.SalarioLiquido);


        // Veiculo volvo = new Veiculo("PLACA_CORRETA");
        // volvo.Marca = "Volvo";
        // volvo.Modelo = "XC90";
        // //volvo.Placa = "VOLVO-PLACA-CLONADO"; //estou usando o set / atribuindo valor
        // Console.WriteLine($"A placa é: { volvo.Placa }"); //aqui apenas lendo
        // Console.WriteLine(volvo.Descricao());


        // int n1 = 10;
        // int n2 = 10;

        // if (n1 == n2)
        // {
        //     Console.WriteLine("Os números são iguais");
        // }

        // Pessoa p = new Pessoa("João", "Silva", 91);
        // Pessoa p2 = new Pessoa("João", "Silva", 91);
        // Pessoa maria = new Pessoa("Maria", "Silva", 88);

        // //Cenário que não funciona como esperamos
        // if (p == p2)
        // {
        //     Console.WriteLine("Teste de 03/03 -> São iguais as pessoas");
        // }
        // else
        // {
        //     Console.WriteLine("Teste de 03/03 -> São diferentes as pessoas");
        // }

        // if (p.Nome == p2.Nome && p.Sobrenome == p2.Sobrenome && p.Idade == p2.Idade)
        // {

        // }

        // if (maria.Nome == p2.Nome && maria.Sobrenome == p2.Sobrenome && maria.Idade == p2.Idade)
        // {
            
        // }

        // if (maria.APessoaEhIgual(p2))
        // {
            
        // }


        // //Cenário que funciona como esperamos
        // if (p.APessoaEhIgual(p2))
        // {
        //     Console.WriteLine("As pessoas são iguais");
        // }
        // else
        // {
        //     Console.WriteLine("As pessoas são diferentes");
        // }
    }
}