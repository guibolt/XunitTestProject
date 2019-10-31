using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LanceCtor
    {
        [Fact]
        public void LancaArgumentExceptionDadosValorNegativo()
        {
            //Arranje
            var valorNegativo = -100;

            Assert.Throws<System.ArgumentException>(
                //Act
                () => new Lance(null, valorNegativo)
                );
        }
    }
}
