namespace banco;

class Conta{
    public int Numero {get; set;}
    private double Saldo{get; set;}//get e set sao privados
    public double Limite{get; private set;}

    public void Depositar(double valor){
        this.Saldo += valor;
    }
    public void Sacar(double valor){
        if(valor > this.Saldo+this.Limite){
            Console.WriteLine("Você não possui esse valor para saque");
        }else{ 
            this.Saldo -= valor;
        }
    }
    public double MostrarSaldo(){
        return this.Saldo+this.Limite;
    }
    public void AjustaLimite(double valor){
        this.Limite = valor;
    }
}