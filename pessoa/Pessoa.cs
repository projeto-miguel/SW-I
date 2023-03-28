namespace pessoa;
class Pessoa{
    public Pessoa(){//elimina erros devido a possíveis valores nulos
        this.Nome = "NÃO INFORMADO";
        this.SobreNome = "NÃO INFORMADO";
        this.Idade = 0;
    }
    public Pessoa(string n, int i){//quantidade de parâmetros/assinatura diferencia os métodos
        this.Nome = n;
        this.Idade = i;
        this.SobreNome = "NÃO INFORMADO";
    }
    private string? Nome {get;set;}
    private string? SobreNome {get;set;}
    private int Idade {get;set;}

    public void AlterarNome(string n){
        this.Nome = n;
    }
    public void AlterarSobreNome(string n){
        this.SobreNome = n;
    }
    public void AlterarIdade(int i){
        this.Idade = i;
    }
    public void Info(){
        Console.WriteLine("Nome.....: {0}",this.Nome);
        Console.WriteLine("Sobrenome: {0}",this.SobreNome);
        Console.WriteLine("Idade....: {0}",this.Idade);
    }
}