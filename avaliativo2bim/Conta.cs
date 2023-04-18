namespace avaliativo2bim;
class Conta{
    private decimal Saldo {get;set;}
    public decimal Limite {get;private set;}
    public int Numero {get;private set;}

    public void AlterarNumero(int n){
        this.Numero = n;
    }
    public decimal ConsultarSaldo(){
        return this.Saldo;
    }
    public void Depositar(decimal v){
        this.Saldo += v;
    }
    public void Sacar(decimal v){
        if(v>this.Saldo){
            Console.WriteLine("Você não possui esse valor para saque.");
        }else{
            this.Saldo -= v;
        }
    }
    public void DefinirLimite(decimal v){
        this.Limite = v;
    }
    public void CalcularJuros(decimal emprestimo,int prazo,decimal taxa){
        decimal prestacao = emprestimo/prazo;//prestacao sem juros
        decimal juros = (taxa/100)*emprestimo;//valor do juros mensal
        decimal prestacaoComJjuros = juros+prestacao;
        decimal total = prestacaoComJjuros*prazo;
        Console.Clear();
        Console.WriteLine("Valor do empréstimo: R${0}",emprestimo); 
        Console.WriteLine("Prazo : {0} meses",prazo);
        Console.WriteLine("Taxa de juros mensal: {0}%",taxa);
        Console.WriteLine("Juros/mês: {0}",juros);
        Console.WriteLine("Valor da prestação: {0}",prestacao);
        Console.WriteLine("Valor da prestação c/ juros: R${0}",prestacaoComJjuros);
        Console.WriteLine("Valor total a pagar: R${0}",total);
    }
}