namespace contrato1;
class ContratoPessoaFisica:Contrato{
    public string? CPF {get;set;}
    public int Idade {get;set;}
    public override void Info()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("INFORMAÇÕES DE PESSOA FISICA: ");
        Console.ResetColor();
        base.Info();        
        Console.WriteLine("CPF: {0}",this.CPF);
        Console.WriteLine("Idade: {0}",this.Idade);
    }
}