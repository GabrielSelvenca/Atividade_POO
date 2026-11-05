namespace Atividade_POO
{
    public class Pessoa
    {
        public string Nome {get; set;} = "Nome não definido";
        public int Idade { get; set; } = 0;
        public string? Cidade { get; set; } = "Cidade não definida";

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Cidade: {Cidade}");
        }
    }
}