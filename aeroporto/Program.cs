namespace aeroporto;
class Program
{
    static void Main(string[] args)
    {
        Aviao a1 = new Aviao("Boeing",123,"Guarulhos-SP","Salvador-BH");
        a1.Info();
        Aviao a2 = new Aviao();
        a2.Info();
    }
}
