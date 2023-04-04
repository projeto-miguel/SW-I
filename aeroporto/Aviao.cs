namespace aeroporto;
class Aviao{
    private string? Empresa {get;set;}
    private int Codigo {get;set;}
    private string? CidadeEntrada {get;set;}
    private string? CidadeSaida {get;set;}
    public Aviao(){
        this.Empresa = "Qatar Airlines";
        this.Codigo = 0;
        this.CidadeSaida = "NAO INFORMADO";
        this.CidadeEntrada = "NAO INFORMADO";
    }
    public Aviao(string e, int c, string ce, string cs){
        this.Empresa = e;
        this.Codigo = c;
        this.CidadeEntrada = ce;
        this.CidadeSaida = cs;
    }
    public void MudarCodigo(int c){
        this.Codigo = c;
    }
    public void MudarEmpresa(string e){
        this.Empresa = e;
    }
    public void Info(){
        Console.WriteLine("_____________________________________");
        Console.WriteLine("CODIGO.........: {0}",this.Codigo);
        Console.WriteLine("EMPRESA........: {0}",this.Empresa);
        Console.WriteLine("CIDADE DE SAIDA: {0}",this.CidadeSaida);
        Console.WriteLine("CIDADE DESTINO.: {0}",this.CidadeEntrada);
    }
}