namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos tipos de produtos você deseja calcular o lucro: ");
            int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

            string?[] nomesProdutos = new string[quantidadeProdutos];
            decimal[] lucros = new decimal[quantidadeProdutos];


            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.Clear();
                Console.WriteLine("Qual o nome do tipo do produto?");
                nomesProdutos[i] = Console.ReadLine();

                Console.WriteLine("Quantas unidades foram vendidas?");
                int quantidades = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o preço de compra?");
                decimal precosCompra = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Qual o preco de venda?");
                decimal precosVenda = Convert.ToDecimal(Console.ReadLine());

                lucros[i] = (precosVenda - precosCompra) * quantidades;
           
            }
            Console.Clear();
            Console.WriteLine("Cada tipo de produto obteve o lucro:" + Environment.NewLine);   

            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine("Produto:" + nomesProdutos[i] + "teve um lucro de: R$" + lucros[i]);
                Console.ReadKey();


            }
        }
    }
}