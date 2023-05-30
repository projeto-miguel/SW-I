namespace EXER02;
class Program
{
    static void Main(string[] args)
    {
        Estadual prodEst = new Estadual();
        Nacional prodNac = new Nacional();
        Importado prodImp = new Importado();
        int opcao = 0;

        Console.WriteLine("Escolha uma operação: 1 - Produto Estadual\n2 - Produto Nacional\n3 - Produto Importado");
        opcao = Convert.ToInt32(Console.ReadLine());
        switch(opcao){
            case 1:
                //instanciando valores para atributos comuns
                Console.WriteLine("Digite a descrição da Prod Estadual");
                prodEst.Descricao = Console.ReadLine();
                Console.WriteLine("Digite o valor do Prod Estadual");
                prodEst.Valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor do imposto do prod Estadual");
                prodEst.Imposto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Valor do produto calculado:");
                Console.WriteLine(prodEst.CalcularValor());
                break;
            case 2:
                //instanciando valores para atributos nacional
                Console.WriteLine("Digite a descrição da Prod Nacional");
                prodNac.Descricao = Console.ReadLine();
                Console.WriteLine("Digite o valor do Prod Nacional");
                prodNac.Valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor do imposto do prod Nacional");
                prodNac.Imposto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor da Taxa do prod Nacional");
                prodNac.Taxa = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Valor do produto calculado com imposto:");
                Console.WriteLine(prodNac.CalcularValor());
                break;
            case 3:
                //instanciando valores para atribuitos Importado

                Console.WriteLine("Digite a descrição da Prod Importado");
                prodImp.Descricao = Console.ReadLine();
                Console.WriteLine("Digite o valor do Prod Importado");
                prodImp.Valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor do imposto do prod Importado");
                prodImp.Imposto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor da Taxa do prod Importado");
                prodImp.Taxa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a taxa de importação: ");
                prodImp.TaxaImport = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Valor do produto calculado com imposto + a Taxa de importação:");
                Console.WriteLine(prodImp.CalcularValor());
                break;
            default:
                Console.WriteLine("Digite o número novamente.");
                break;
        }


        
        
    }
}
