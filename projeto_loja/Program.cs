namespace projeto_loja;
class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto();
        Produto p2 = new Produto("XYZ");
        Produto p3 = new Produto("ABC",10);
        p1.Info();
        p2.Info();
        p3.Info();
    }
}
