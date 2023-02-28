namespace Banco;

class Transacao{
    public string agencia = "";
    public decimal valor;
    public string tipo = "";
    public int conta;
    public Transacao(string a, decimal v, string tp, int c){
        this.agencia = a;
        this.valor = v;
        this.tipo = tp;
        this.conta = c;
    }

    public decimal GetValor(){
        return this.valor;
    }
    public void SetTipo(string t){
        this.tipo = t;
    }
    public string GetAgencia(){
        return this.agencia;
    }
    public int GetConta(){
        return this.conta;
    }
}