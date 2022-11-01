namespace Abstract.Models
{
    public class ContaCorrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }

    }
}