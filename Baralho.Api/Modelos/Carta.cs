using Baralho.Api.Enums;

namespace Baralho.Api.Modelos
{
    public class Carta
    {
         public Carta(string nome, Naipe naipe)
        {
            Nome = nome;
            Naipe = naipe;
        }

        public string Nome { get; }
        public Naipe Naipe { get; }

        public override string ToString() => $"{Nome} de {Naipe}";
    }
}
