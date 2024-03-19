using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            string opera;
            Console.WriteLine("Digite o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação: (+, -, X, /)");
            opera = Console.ReadLine().ToLower();

            switch (opera)
            {
                case "+":
                    Console.WriteLine("A soma é: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("A subtração é: " + (num1 - num2));
                    break;
                case "x":
                    Console.WriteLine("A multiplicação  é: " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("A divisão é: " + (num1/num2));
                    break;
                default:
                    Console.WriteLine("Operação invalida");
                    break;

            }

            Console.ReadKey();

        }
    }
}
