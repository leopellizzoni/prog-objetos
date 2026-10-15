using System;

namespace ConsoleAppAula01;

public class Funcionario
{
    public Funcionario(String nome, String cargo, decimal salarioBruto)
    {
        Nome = nome;
        Cargo = cargo;
        SalarioBruto = salarioBruto;   
        GerarSalarioLiquido(); 
    }

    public String Nome { get; set; }

    public String Cargo { get; set; }

    public decimal SalarioBruto { get; set; }

    public decimal SalarioLiquido { get; private set;}

    public decimal GerarSalarioLiquido()
    {
        DescontarINSS();
        DescontarIR();
        ContribuirFGTS();

        return SalarioLiquido;
    }

    private void DescontarINSS()
    {
        if (SalarioBruto <= 1518)
        {
            SalarioLiquido = SalarioBruto * 0.925m;
        }   
    }

    private void DescontarIR()
    {   
    }

    private void ContribuirFGTS()
    {
        
    }

    
}
