namespace cartaocredito;
class Program
{
    static void Main(string[] args)
    {
        Cartao cc1 = new Cartao();
        Cliente c1 = new Cliente();
        c1.Nome = "Miguel";
        cc1.Numero = "1234567890";
        cc1.Validade = "31/12/2023";
        cc1.Cliente = c1;

        
        Console.WriteLine("O nome do cliente é: "+c1.Nome);
        Console.WriteLine("O número do cartão é: " + cc1.Numero);
        Console.WriteLine("A validade do cartão é: " +cc1.Validade);
        Console.WriteLine("O cliente agregado ao cartão é: " +cc1.Cliente.Nome);
    }
}
