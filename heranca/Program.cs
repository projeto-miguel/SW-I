namespace heranca;
class Program
{
    static void Main(string[] args)
    {
        FuncionarioN1 f1 = new FuncionarioN1();
        FuncionarioN2 f2 = new FuncionarioN2();
        FuncionarioN3 f3 = new FuncionarioN3();

        f1.Nome = "Miguel";
        f1.Idade = 15;

        f2.Nome = "Fulano";
        f2.Idade = 16;

        f3.Nome = "Cicrano";
        f3.Idade = 17;
        f3.Cargo = "Repositor";

        Console.WriteLine("Nome: {0} -- Idade: {1} -- Lucro: {2}",f1.Nome,f1.Idade,f1.Lucro());
        Console.WriteLine("Nome: {0} -- Idade: {1} -- Lucro: {2}",f2.Nome,f2.Idade,f2.Lucro());
        Console.WriteLine("Nome: {0} -- Idade: {1} -- Lucro: {2} -- Cargo {3}",f3.Nome,f3.Idade,f3.Lucro(),f3.Cargo);
    }
}
