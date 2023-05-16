namespace contrato1;
class Contrato{
    public string? Nome {get;set;}
    public string? Email {get;set;}
    public string? Telefone {get;set;}
    public virtual void Info(){
        Console.WriteLine("Nome: {0}",this.Nome);
        Console.WriteLine("Email: {0}",this.Email);
        Console.WriteLine("Telefone: {0}",this.Telefone);
    }
}