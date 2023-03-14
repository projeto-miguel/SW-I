namespace alunosmedia;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        Console.WriteLine("Digite o nome do aluno: ");
        aluno1.nome = Console.ReadLine();
        Console.WriteLine("Informe a primeira nota do aluno: ");
        aluno1.n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota do aluno: ");
        aluno1.n2 = double.Parse(Console.ReadLine());
        aluno1.InfoAluno(); 
    }
}
