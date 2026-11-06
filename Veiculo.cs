using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

namespace Atividade_POO
{
    public class Veiculo
    {
        private int _velocidade;

        public int Velocidade
        {
            get => _velocidade;
            set
            {
                try
                {
                    if (value < 0 || value > 200)
                    {
                        throw new Exception("O valor não pode ser maior que 200 ou menor que 0");
                    }
                    _velocidade = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}