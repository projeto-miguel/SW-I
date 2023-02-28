namespace Banco;
class Program{
    static void Main(){
        Transacao t1 = new Transacao("Mauá",30000,"Pagamento",23049834);
        Console.WriteLine(t1.GetValor());
        Console.WriteLine(t1.GetAgencia());
        Console.WriteLine(t1.GetConta());
        t1.SetTipo("Depósito");
        Console.WriteLine(t1.tipo);

    }
}
