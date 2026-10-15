//Produto: cod + nome + valor


using ProjetoMercado;

Console.WriteLine("Programa do Mercado");

Produto leite = new Produto(5);
//leite.Codigo = 1; //comentamos porque foi no construtor
leite.Nome = "Leite Santa Clara";
leite.Valor = 4.67;
int codigoatual = leite.Codigo;

Produto cafe = new Produto(2);
//cafe.Codigo = 2; //foi para o construtor;
cafe.Nome = "Cafe Bom Jesus";
cafe.Valor = 25.99;

Produto desinfetante = new Produto(3);
desinfetante.Nome = "Veja Por";
desinfetante.Valor = 15;

Console.WriteLine("Seus Produtos");
// Console.WriteLine("Codigo: " + leite.Codigo + 
//     " Nome: " + leite.Nome + 
//     " Valor: " + leite.Valor);

// Console.WriteLine("Codigo: " + cafe.Codigo + 
//     " Nome: " + cafe.Nome + 
//     " Valor: " + cafe.Valor);

// Console.WriteLine("Codigo: " + desinfetante.Codigo + 
//     " Nome: " + desinfetante.Nome + 
//     " Valor: " + desinfetante.Valor);

leite.ImprimirDescricao();
cafe.ImprimirDescricao();
desinfetante.ImprimirDescricao();

Pessoa p1 = new Pessoa();
p1.Nome = "João da Silva";
p1.CPF = 0000000001;
p1.DataDeNascimento = new DateTime(2025, 3, 18);



