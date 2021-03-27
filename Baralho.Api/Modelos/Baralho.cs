using Baralho.Api.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Baralho.Api.Modelos
{
    public class Baralho
    {
        public IList<Carta> Cartas => CriarBaralho();
        public IList<Carta> CartasEmbaralhadas => EmbaralharCartas();


        private readonly IReadOnlyCollection<string> _valoresCartas = new Collection<string>
                    {
                        "AS", "2", "3", "4", "5", "6", "7", "8", "9", "10", "DAMA", "VALETE", "REI"
                    };


        private IList<Carta> CriarBaralho()
        {
            var cartas = new List<Carta>();

            foreach (var valor in _valoresCartas)
                cartas.AddRange(Enum.GetValues(typeof(Naipe))
                    .Cast<object>()
                    .Select(naipe => new Carta(valor, (Naipe)naipe)));

            return cartas;
        }

        private IList<Carta> EmbaralharCartas()
        {
            var random = new Random();
            return Cartas.Select(c => new { c, r = random.Next() }).OrderBy(@t => @t.r).Select(@t => @t.c).ToList();
        }
    }
}
