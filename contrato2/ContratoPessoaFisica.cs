namespace contrato2;
class ContratoPessoaFisica:Contrato{
    public string? CPF {get;set;}
    public int Idade {get;set;}
    public override decimal CalcularPrestacao(decimal valor, int meses)
    {
        if(this.Idade <= 30){
            return base.CalcularPrestacao(valor, meses)+1;
        }else if(this.Idade <=40){
            return base.CalcularPrestacao(valor,meses)+2;
        }else if(this.Idade <=50){
            return base.CalcularPrestacao(valor,meses)+3;
        }else{
            return base.CalcularPrestacao(valor,meses)+4;
        }
    }
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