namespace EXER02;
class Nacional:Produto{
    public double Taxa { get; set; }
    public override double CalcularValor()
    {
        double tx = this.Valor*(this.Taxa/100);
        return base.CalcularValor()+tx;
    }

}