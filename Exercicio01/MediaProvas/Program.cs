using System.Dynamic;

namespace MediaProvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2;
            int media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado");

            }else
            {
                Console.WriteLine("Aluno Reprovado");

            }
            Console.ReadKey();


        }
    }
}