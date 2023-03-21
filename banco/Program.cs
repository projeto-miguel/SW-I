namespace banco;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco Etec MCM");
        Conta c = new Conta();/*
        c.Saldo = 1500 set publico sem uso de metodos
        */
        c.Depositar(1000); //set privado, nao pode ser feito diretamente
        /*
        c.Limite = 500; set publico
        */
        c.AjustaLimite(500);
        c.Sacar(15600);
        /*
        Console.WriteLine("Seu saldo é de: " + c.Saldo);//get publico
        Console.WriteLine("Seu limite é de: "+ c.Limite);//get  publico
        */
        Console.WriteLine("Valor total na sua conta: "+ c.MostrarSaldo());
    }
}