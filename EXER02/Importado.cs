namespace EXER02;
class Importado:Produto{
    
    public double Taxa { get; set; }
    public double TaxaImport { get; set; }
    public override double CalcularValor()
    {
        double tx = this.Valor*(this.Taxa/100);
        double tximp = this.Valor*(this.TaxaImport/100);
        return base.CalcularValor()+tx+tximp;
    }
}