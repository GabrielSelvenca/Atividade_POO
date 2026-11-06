namespace Atividade_POO
{
    public class Funcionario
    {
        public string? Nome {get; set;}
        public string? Cargo {get; set;}
        public decimal Salario {get; private set;} = 100.00m;

        public void AumentarSalario(int percentual)
        {
            Salario += percentual/100m * Salario;
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"O funcionário {Nome} do cargo {Cargo} recebe: {Salario}");
        }


    }
}