namespace contrato2;
class ContratoPessoaJuridica:Contrato{
    public string? CNPJ {get;set;}
    public int Ie {get;set;}
    public override decimal CalcularPrestacao(decimal valor, int meses)
    {
        return base.CalcularPrestacao(valor, meses)+3;
    }
    public override void Info()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("INFORMAÇÕES DE PESSOA JURIDICA");
        Console.ResetColor();
        base.Info();
        Console.WriteLine("CNPJ: {0}",this.CNPJ);
        Console.WriteLine("Inscrição estadual: {0}",this.Ie);
    }
}