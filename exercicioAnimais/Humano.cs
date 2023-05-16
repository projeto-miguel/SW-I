namespace exercicioAnimais;
class Humano:Animal{
    public override string Fala()
    {
        return base.Fala() + "Oi";
    }
}