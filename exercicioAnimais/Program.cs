namespace exercicioAnimais;
class Program
{
    static void Main(string[] args)
    {
        Humano h1 = new Humano();
        Gato g1 = new Gato();
        Cachorro c1 = new Cachorro();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Humano diz: {0}",h1.Fala());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Gato diz: {0}",g1.Fala());
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Cachorro diz: {0}",c1.Fala());
        Console.ResetColor();
    }
}
