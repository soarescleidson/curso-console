using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, operacao;
            string cliente = "", produto = "";
            do{
            Console.Clear();
            Console.WriteLine("1-Cliente");
            Console.WriteLine("2-produto");
            Console.WriteLine("3-Sair");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("1- Cadastrar Cliente ");
                    Console.WriteLine("2- Consultar Cliente");
                    break;
                case 2:
                    Console.WriteLine("1-cadastrar produto");
                    Console.WriteLine("2-Consultar produto");
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Operacao Invalida!");
                    break;
            }
            if ((opcao.Equals(1)))
            {
                operacao = Convert.ToInt32(Console.ReadLine());
                if (operacao.Equals(1))
                {
                    Console.WriteLine("informe o nome:");
                    cliente = Console.ReadLine();
                }
                else if ((operacao.Equals(2)))
                {
                    Console.WriteLine("nome do Cliente:" + cliente);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Opçao Invalida!");
                }
            }
            else if ((opcao.Equals(2)))
            {
                operacao = Convert.ToInt32(Console.ReadLine());
                if (operacao.Equals(1))
                {
                    Console.Write("Informe o nome:");
                    produto = Console.ReadLine();
                }
                else if ((operacao.Equals(2)))
                {
                    Console.Write("Descriçao:" + produto);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("opcao invalida!");
                }
            }

        } while (opcao != 3);


        }
    }
}
 
