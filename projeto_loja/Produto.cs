namespace projeto_loja;
class Produto{
    public Produto(){
        this.Nome = "TICTOC";
        this.Preco = 15;
    }
    public Produto(string n){
        this.Nome = n;
        this.Preco = 10;
    }
    public Produto(string n, int desconto){
        this.Nome = n;
        this.Preco = 10 - (10*desconto/100);
    }
    private string? Nome {get;set;}
    private double Preco {get;set;}
    public void AlterarNome(string n){
        this.Nome = n;
    }
    public  void AlterarPreco(double p){
        this.Preco = p;
    }
    public void Info(){
        Console.WriteLine("Nome: {0}",this.Nome);
        Console.WriteLine("Preco: {0}",this.Preco);
    }
}