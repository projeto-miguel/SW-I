namespace aviao;

class Program{
    static void Main(){
        Aviao a1 = new Aviao("777","Boeing",30000,400);
        a1.Info();
        a1.Acelerar();
        a1.Descer();
        a1.Info();
    }
}
