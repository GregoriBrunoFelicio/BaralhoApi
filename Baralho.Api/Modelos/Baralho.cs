using Baralho.Api.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Baralho.Api.Modelos
{
    public class Baralho
    {
        public List<Carta> Cartas => CriarBaralho();
        public List<Carta> CartasEmbaralhadas => EmbaralharCartas();
        private IEnumerable<string> ValoresCartas = new List<string>
        {
            "AS", "2", "3","4","5","6","7","8","9","10","DAMA","VALETE", "REI"
        };

        private List<Carta> CriarBaralho()
        {
            var cartas = new List<Carta>();

            foreach (var valor in ValoresCartas)
            {
                foreach (var naipe in Enum.GetValues(typeof(Naipe)))
                {
                    cartas.Add(new Carta(valor, (Naipe)naipe));
                }
            }

            return cartas;
        }

        private List<Carta> EmbaralharCartas()
        {
            var random = new Random();

            var cartasEmbaralhadas = from c in Cartas let r = random.Next() orderby r select c;

            return cartasEmbaralhadas.ToList();
        }
    }
}
