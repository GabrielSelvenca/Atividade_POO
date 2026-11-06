namespace Atividade_POO
{
    public class Livro
    {
        public string? Titulo { get; set; } = "Oie";
        public string? Autor { get; set; } = "Joãozinho";
        public int NumeroPaginas { get; set; } = 200;

        public Livro()
        {
            
        }

        public Livro(string titulo)
        {
            Titulo = titulo;
        }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public Livro(string titulo, string autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }
    }
}