namespace exercicioAnimais;
class Gato:Animal{
    public override string Fala()
    {
        return base.Fala()+"Miau miau";
    }
}