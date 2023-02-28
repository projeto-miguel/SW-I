namespace aviao;

class Aviao{
    public string modelo;
    public string marca;
    public double altitude;
    public double vel;
    public Aviao(string m, string ma, double a, double v){
        this.modelo = m;
        this.marca = ma;
        this.altitude = a;
        this.vel = v;
    }
    public void Reduzir(){
        this.vel-=10;
    }
    public void Acelerar(){
        this.vel+=10;
    }
    public void Subir(){
        this.altitude+=10;
    }
    public void Descer(){
        this.altitude-=10;
    }
    public void Info(){
        Console.WriteLine("---------------------------");
        Console.WriteLine("Modelo: {0}",this.modelo);
        Console.WriteLine("Marca: {0}",this.marca);
        Console.WriteLine("Altitude: {0}",this.altitude);
        Console.WriteLine("Velocidade: {0}",this.vel);
    }
}