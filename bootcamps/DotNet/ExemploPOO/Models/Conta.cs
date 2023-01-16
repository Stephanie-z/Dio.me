namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo { get; set; }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }

        public abstract void Creditar(decimal valor);
    }
}
