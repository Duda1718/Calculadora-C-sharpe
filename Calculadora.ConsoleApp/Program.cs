using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string historico = "";

            do
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine(historico);
                Console.WriteLine("Selecione a operação\n");
                Console.WriteLine("Digite: \n 1 para soma \n 2 para subtração\n 3 para multiplicação\n 4 para divisão \n 5 para ver o histórico \n S para sair do programa \n");
                string opcaoMenu = Console.ReadLine();
                double primeiroNumero = 0;
                double segundoNumero = 0;

                if (opcaoMenu == "S" || opcaoMenu == "s")
                    {
                    Console.WriteLine("Saindo do programa");
                    Console.ReadLine();
                    break;
                }

                if (opcaoMenu != "5")
                {
                    Console.WriteLine("Digite o primeiro número");
                    primeiroNumero = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número");
                    segundoNumero = Convert.ToDouble(Console.ReadLine());

                }
               
                double resultado = 0;
                string operacao = "";

                switch (opcaoMenu)
                {

                    case "1":
                        resultado = primeiroNumero + segundoNumero;
                        operacao = " + ";
                        Console.WriteLine($"O resultado é {resultado}");
                        Console.ReadLine();
                        break;

                    case "2":
                        resultado = primeiroNumero - segundoNumero;
                        operacao = " - ";
                        Console.WriteLine($"O resultado é {resultado}");
                        Console.ReadLine();
                        break;

                    case "3":
                        resultado = primeiroNumero * segundoNumero;
                        operacao = " * ";
                        Console.WriteLine($"O resultado é {resultado}");
                        Console.ReadLine();
                        break;

                    case "4":
                        while (segundoNumero == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Digite um número diferente de zero");
                            Console.ReadLine();
                            Console.ResetColor();
                            Console.WriteLine("Digite o Segundo número");
                            segundoNumero = Convert.ToDouble(Console.ReadLine());
                        }

                        resultado = primeiroNumero / segundoNumero;
                        Console.WriteLine($"O resultado é {resultado.ToString("F2")}");
                        operacao = " / ";
                        Console.ReadLine();
                        break;

                     case "5":
                        Console.WriteLine(historico);
                        Console.ReadLine() ;
                        break;

                    default: 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Operação Inválida");
                        break;
                }
               historico += primeiroNumero.ToString() + operacao + segundoNumero.ToString() + " = " + resultado.ToString() + "\n";

            } while (true);

        }
    }
}
