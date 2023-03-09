using System.Threading.Channels;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            while (opcao != "S")
            {
                Console.Clear();
                Console.WriteLine("Calculadora Rafael Cesar de Souza");

                Console.WriteLine("\nPara Somar, digite 1");
                Console.WriteLine("Para Subtrair, digite 2");
                Console.WriteLine("Para Multiplicar, digite 3");
                Console.WriteLine("Para Dividir, digite 4");
                Console.WriteLine("Para sair, digite [S]");
                Console.Write("\n=> ");

                opcao = Console.ReadLine();
                if (opcao.ToUpper() == "S")
                {
                    break;
                }
                double num1 = 0;
                double num2 = 0;
                
                Console.Write("\nDigite o primeiro número: ");
                double.TryParse(Console.ReadLine(), out num1);
                Console.Write("Digite o segundo número: ");
                double.TryParse(Console.ReadLine(), out num2);

                switch (opcao)
                {
                    case "1":
                        
                        double resultado = num1 + num2;
                        Console.WriteLine($"\nO resultado da adição é: {resultado}\n");
                        break;

                    case "2":
                    
                        resultado = num1 - num2;
                        Console.WriteLine($"\nO resultado da subtração é: {resultado}\n");
                        break;

                    case "3":
                        
                        resultado = num1 * num2;
                        Console.WriteLine($"\nO resultado da multiplicação é: {resultado}\n");
                        break;

                    case "4":
                        
                        if (num2 == 0)
                        {
                            Console.WriteLine("\nErro: divisão por zero!\n");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"\nO resultado da divisão é: {resultado}\n");
                        }
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.\n");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();

            }

        }
    }
}