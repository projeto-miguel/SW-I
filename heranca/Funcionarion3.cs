namespace heranca;
class FuncionarioN3 : Funcionario{
    public string? Cargo {get;set;}
    public override double Lucro(){
        return base.Lucro() * 0.03;
    }
}