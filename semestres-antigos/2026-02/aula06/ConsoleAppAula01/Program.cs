using ConsoleAppAula01;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo veiculoTeste = new Moto();
        (veiculoTeste as Moto).CC = 150;
        veiculoTeste.Placa = "AAAA222";
        veiculoTeste.Modelo = "CG";
        veiculoTeste.Marca = "Honda";
        //GERA ERRO
        //Console.WriteLine((veiculoTeste as Caminhao).PesoTotalParaTransporte);

        Veiculo meuCaminhao = new Caminhao();
        (meuCaminhao as Caminhao).PesoTotalParaTransporte = 150;
        meuCaminhao.Placa = "AAAA2122";
        meuCaminhao.Modelo = "XX2";
        meuCaminhao.Marca = "Volvo";
        Console.WriteLine((meuCaminhao as Caminhao).PesoTotalParaTransporte);
        
        Gerente g = new Gerente();
        g.VeiculoDoFuncionario = new Carro();

        Motorista m = new Motorista();
        m.VeiculoDoFuncionario = new Caminhao();

        OfficeBoy boy = new OfficeBoy();
        boy.VeiculoDoFuncionario = new Moto();

    }
}