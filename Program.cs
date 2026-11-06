using Atividade_POO;

// Pessoa p1 = new Pessoa();
// Pessoa p2 = new Pessoa();
// p1.Nome = "Diogo";
// p1.Idade = 22;
// p1.Cidade = "Santo André";

// p2.Nome = "Lucas";
// p2.Idade = 25;
// p2.Cidade = "São Paulo";

// p1.Apresentar();
// p2.Apresentar();

// Calculadora calc = new Calculadora();

// Console.WriteLine(calc.Somar(10, 10));
// Console.WriteLine(calc.Subtrair(10, 60));
// Console.WriteLine(calc.Multiplicar(35, 10.5));
// Console.WriteLine(Calculadora.Dividir(10m, 50m));

// Veiculo v = new Veiculo();

// v.Velocidade = 201;
// Console.WriteLine(v.Velocidade);
// v.Velocidade = 10;
// Console.WriteLine(v.Velocidade);
// v.Velocidade = 180;
// Console.WriteLine(v.Velocidade);
// v.Velocidade = -1;
// Console.WriteLine(v.Velocidade);

// Funcionario f = new Funcionario();

// f.Nome = "João";
// f.Cargo = "Servente de pedreiro";
// //f.Salario = 2000; // Não permite alterar salário por conta do private set;
// f.AumentarSalario(10);
// f.ConsultarSalario();

Livro l1 = new Livro();
Livro l2 = new Livro("Titulo1");
Livro l3 = new Livro("Titulo2", "Autor1");
Livro l4 = new Livro("Titulo3", "Autor2", 9000);

Console.WriteLine($"{l1.Titulo} {l1.Autor} {l1.NumeroPaginas}");
Console.WriteLine($"{l2.Titulo} {l2.Autor} {l2.NumeroPaginas}");
Console.WriteLine($"{l3.Titulo} {l3.Autor} {l3.NumeroPaginas}");
Console.WriteLine($"{l4.Titulo} {l4.Autor} {l4.NumeroPaginas}");