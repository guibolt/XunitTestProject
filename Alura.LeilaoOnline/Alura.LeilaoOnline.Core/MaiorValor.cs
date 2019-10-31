using Alura.LeilaoOnline.Core;
using System.Linq;

namespace Alura.LeilaoOnline.Tests
{
    public class MaiorValor : IModalidadeAvaliacao
    {
        public Lance Avalia(Leilao leilao) => leilao.Lances.DefaultIfEmpty(new Lance(null, 0)) .OrderBy(l => l.Valor).LastOrDefault();

    }
}