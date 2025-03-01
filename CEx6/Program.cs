namespace CEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("\nInforme o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine()!);
            Console.Write("\nInforme o valor da hora trabalhada: ");
            double valor = double.Parse(Console.ReadLine()!);

            double salario = horas * valor;

            Console.WriteLine($"\nO funcionário {nome} trabalhou {horas} horas e deve receber R${salario}");
        }
    }
}
