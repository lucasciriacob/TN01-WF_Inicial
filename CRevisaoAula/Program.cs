using System.Net.Http.Headers;

namespace CRevisaoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Escreva sua primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva sua segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double media = n1 + n2 / 2;

            Console.WriteLine("Sua média é= {0}", media;

            if (media > 6)
            {
                Console.WriteLine("Status = Aprovado");
            }
            else if (media >= 5)
            {
                Console.WriteLine("Status = Recuperação");
            }
            else 
            {
                Console.WriteLine("Status = Reprovado");
            }
        }
    }
}
