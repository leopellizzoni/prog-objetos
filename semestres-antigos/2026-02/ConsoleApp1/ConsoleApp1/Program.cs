using ConsoleApp1;

Categoria catEletronico = new Categoria("Eletrônico");
Produto produto1 = new Produto("Notebook", catEletronico);
Console.WriteLine(produto1.Nome + " - " + produto1.Categoria.Nome);

object produto2 = new Celular("Smartphone", catEletronico);
Console.WriteLine(produto2.Nome);

Produto produto3 = new Produto("Tablet", catEletronico);
Console.WriteLine(produto3.Nome);

Livro livro = new Livro("Clean Code", new Categoria("Livro"));
livro.Autor = "Robert Martin";
Console.WriteLine(livro.Nome + " - " + livro.Autor);

Livro livro = new Livro("Design Patterns", new Categoria("Livro"));
livro.Autor = "GoF";
Console.WriteLine(livro.Nome + " - " + livro.Autor);

Produto livroPremium = new Livro("Refactoring", new Categoria("Livro"));
livroPremium.Autor = "Martin Fowler";
Console.WriteLine(livroPremium.Nome + " - " + livroPremium.Autor);


