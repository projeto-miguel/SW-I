namespace contrato2;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica pessoa1 = new ContratoPessoaFisica();
        ContratoPessoaJuridica empresa1 = new ContratoPessoaJuridica();
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("CADASTRO DE PESSOA FISICA");
        Console.ResetColor();
        Console.WriteLine("Digite o seu nome: ");
        pessoa1.Nome = Console.ReadLine();
        Console.WriteLine("Digite seu email: ");
        pessoa1.Email = Console.ReadLine();
        Console.WriteLine("Digite seu telefone: ");
        pessoa1.Telefone = Console.ReadLine();
        Console.WriteLine("Digite seu CPF: ");
        pessoa1.CPF = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        pessoa1.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("CADASTRO DE PESSOA JURÍDICA");
        Console.ResetColor();
        Console.WriteLine("Digite o seu nome: ");
        empresa1.Nome = Console.ReadLine();
        Console.WriteLine("Digite seu email: ");
        empresa1.Email = Console.ReadLine();
        Console.WriteLine("Digite seu telefone: ");
        empresa1.Telefone = Console.ReadLine();
        Console.WriteLine("Digite seu CNPJ: ");
        empresa1.CNPJ = Console.ReadLine();
        Console.WriteLine("Digite a inscrição estadual: ");
        empresa1.Ie = int.Parse(Console.ReadLine());


        Console.Clear();
        pessoa1.Info();
        Console.WriteLine("Valor da prestação: {0}",pessoa1.CalcularPrestacao(4000,12));
        empresa1.Info();
        Console.WriteLine("Valor da prestação: {0}",empresa1.CalcularPrestacao(6000,5));
    }
}
