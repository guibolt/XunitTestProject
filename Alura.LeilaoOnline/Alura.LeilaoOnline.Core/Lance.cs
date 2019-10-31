namespace Alura.LeilaoOnline.Core
{
    public class Lance
    {
        public Interessada Cliente { get; }
        public double Valor { get; }

        public Lance(Interessada cliente, double valor)
        {
            if (valor < 0)
                throw new System.ArgumentException("Não é possivel realizar lances negativos");

            Cliente = cliente;
            Valor = valor;
        }
    }
}
