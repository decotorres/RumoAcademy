namespace ConsumoDeUmVeiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double consumo;

            Console.WriteLine("Informe a distancia a percorrer:");
            distancia = int.Parse(Console.ReadLine());

            consumo = distancia / 12.00;

            Console.WriteLine("A quantidade de combuntível é: {0:N}", consumo);



        }
    }
}