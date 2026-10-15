using ConsoleAppAula01;

internal class Program
{
    private static void Main(string[] args)
    {
        // try
        // {
        //     Console.Write("Informe um numero: ");
        //     int numero = int.Parse(Console.ReadLine());

        //     if (numero % 2 == 0)
        //     {
        //         Console.WriteLine("Par");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Impar");
        //     }
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine("Por favor, informe um número");
        // }
        // finally
        // {
        //     Console.WriteLine("Executou o Finally");
        // }

        // Console.Write("Informe um texto: ");
        // String texto = Console.ReadLine();
        // throw new Exception();
        // Console.WriteLine($"Seu texto é: {texto}");

        try
        {
            Pessoa p = new Pessoa();
            p.Nome = "Leonardo";
            p.Idade = 17;
            Console.WriteLine(p.PodeBeber());

            ServicoDePessoa servico = new ServicoDePessoa();
            if (servico.Processar(p))
            {
                //------Envio avisos por email avisando que foi processado
                //------Envio SMS avisando que foi processado
                // 
            }
        }
        catch (ExcecaoDeRegraDoSistema erroDeSistema)
        {
            Console.WriteLine(erroDeSistema.Message);
        }
        catch (Exception minhaVariavelErro)
        {
            Console.WriteLine("===========================");
            Console.WriteLine(minhaVariavelErro.Message);
            Console.WriteLine("===========================");
        }

        //Gera o erro mesmo que a exception foi criada (via classe) e instanciada (via new) por nos.
        // Pessoa p1 = new Pessoa();
        // p1.Nome = "Leonardo";
        // p1.Idade = 17;
        // Console.WriteLine(p1.PodeBeber());

        // ServicoDePessoa servico1 = new ServicoDePessoa();
        // if (servico1.Processar(p1))
        // {
        //     //------Envio avisos por email avisando que foi processado
        //     //------Envio SMS avisando que foi processado
        //     // 
        // }

        try
        {
            int.Parse("noventa");
        }
        catch (Exception ex)
        {
           throw new ExcecaoDeRegraDoSistema("Ocorreu um erro", ex);
        }
    }
}