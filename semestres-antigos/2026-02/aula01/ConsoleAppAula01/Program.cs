using ConsoleAppAula01;

internal class Program
{
    private static void Main(string[] args)
    {
        int n1 = 10;
        int n2 = 10;

        if (n1 == n2)
        {
            Console.WriteLine("Os números são iguais");
        }

        Pessoa p = new Pessoa("João", "Silva", 91);
        Pessoa p2 = new Pessoa("João", "Silva", 91);
        Pessoa maria = new Pessoa("Maria", "Silva", 88);

        maria.Igual(p2);
        //p.Nome == p2.Nome && p.Sobrenome == p2.Sobrenome && p.Idade == p2.Idade
        p.Igual_NaoFazer(p, p2);
        if (p.Igual(p2))
        {
            Console.WriteLine("As pessoas são iguais");
        }
        else
        {
            Console.WriteLine("As pessoas são diferentes");
        }
    }
}