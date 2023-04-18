namespace avaliativo2bim;
class Program
{
    static void Main(string[] args)
    {
        Conta conta1 = new Conta();
        conta1.Depositar(2000);

        conta1.DefinirLimite(500);
        
        conta1.AlterarNumero(12345);

        conta1.Sacar(1500);

        Console.WriteLine("Valor na conta: "+conta1.ConsultarSaldo());

        conta1.CalcularJuros(1000,12,6);
    }
}
