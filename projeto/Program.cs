using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nomeDoProduto;

                int quantidade;

                double valorDoProduto, valorTotal;

                Console.Write("Digite o nome do produto: ");
                nomeDoProduto = Console.ReadLine();

                Console.Write("Digite o valor do produto: ");
                valorDoProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade: ");
                quantidade = Convert.ToInt32(Console.ReadLine());

                valorTotal = quantidade * valorDoProduto;

                Console.Clear();
                Console.WriteLine(" ****** Venda do Produto *****");
                Console.WriteLine(" Produtos: " + nomeDoProduto);
                Console.WriteLine(" Qtde: " + quantidade + " e Valor Unitário: " + valorDoProduto);
                //.toString() -> Converte o numero para o texto. o "C" -> formata para moeda
                Console.WriteLine(" Total de Venda: " + valorTotal.ToString("C"));

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Digita numero seu Animal");
            }
           
                Console.ReadKey();
            
        }

    }
}