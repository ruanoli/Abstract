namespace Abstract.Models
{
    public abstract class Conta
    {
        protected decimal saldo { get; set; }

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é de: {saldo}");
        }
    }
}