namespace alunosmedia;

class Aluno{
    public string nome = "";
    public double n1, n2;
    public double CalcularMedia(){
        double media = (n1+n2)/2;
        return media;
    }
    public string SituacaoAluno(double m){
        string situacao;
        if(m>=6){
            situacao = "Aprovado";
        }else{
            situacao = "Reprovado";
        }
        return situacao;
    }
    public void InfoAluno(){
        double meidaAluno = CalcularMedia();
        Console.WriteLine("O aluno "+this.nome+" ficou com média final: "+meidaAluno);
        Console.WriteLine("O aluno foi "+this.SituacaoAluno(meidaAluno));
    }

}