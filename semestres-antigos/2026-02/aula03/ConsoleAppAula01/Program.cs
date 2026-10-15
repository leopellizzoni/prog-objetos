using ConsoleAppAula01;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario andre = new Funcionario("ANDRE", 50000);
        andre.Cargo.Codigo = 999;
        andre.Cargo.Descricao = "Médico";
        //andre.Cargo.Representante = new Conselho();
        andre.Cargo.Representante.Codigo = "CRM";
        andre.Cargo.Representante.Nome = "Conselho Regional Medicina";

        Funcionario joao = new Funcionario("João", 25000);
        joao.Cargo.Codigo = 123456;
        joao.Cargo.Descricao = "Eng. de Software";

        Console.WriteLine(joao.QuemEh());

        CargoInfo cargoProgramador = new CargoInfo();
        cargoProgramador.Codigo = 123;
        cargoProgramador.Descricao = "Dev";
        cargoProgramador.Representante.Codigo ="CREA";
        cargoProgramador.Representante.Nome = "Conselho ......";

        Funcionario pedro = new Funcionario("Pedro", 5000);
        pedro.Cargo = cargoProgramador;
        Console.WriteLine(pedro.QuemEh());

        Funcionario maria = new Funcionario("Maria", 5000);
        //maria.Cargo = cargoProgramador;
        maria.Cargo.Codigo = 123;
        maria.Cargo.Descricao = "Dev";
        Console.WriteLine(maria.QuemEh());

        cargoProgramador.Descricao = "Programador de Computador";
        Console.WriteLine(pedro.QuemEh());
        Console.WriteLine(maria.QuemEh());

        Funcionario paulo = new Funcionario("Paulo", 14000);
        paulo.Cargo.Codigo = 777;
        paulo.Cargo.Descricao = "Gerente Administrativo";
        Console.WriteLine(paulo.QuemEh());

        Console.WriteLine("==== THE END");

    }
}