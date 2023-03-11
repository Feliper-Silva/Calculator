using System;

namespace Calculator
{
    class Program 
    {
        static void Main (string[] args) 
        {
            Console.Clear();
            Console.Write("Bem Vindo(a) a nossa primeira calculadora em c#\nDeseja Iniciar ?\n1 - Iniciar\n2 - Encerrar Calculadora\n");
            int opcao = int.Parse(Console.ReadLine());
            while(opcao == 1)
            {           
                int count =0;
                Console.WriteLine("Digite o primeiro valor");
                float number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                float number2 = float.Parse(Console.ReadLine());

                Console.Write("Escolha uma opção abaixo:\n1 - Soma\n2 - Multiplicação\n3 - Divisão\n4 - Encerrar Calculadora\n");
                int acao = int.Parse(Console.ReadLine());


                float result;

                switch (acao){
                    case 1:
                        result = number1 + number2;
                        Console.WriteLine($"O resultado da Soma :\n{number1}  + {number2} = {result}");
                        count ++;
                        break;
                    case 2:
                        result = number1 * number2;
                        Console.WriteLine($"O resultado da Multiplicação :\n{number1}  * {number2} = {result}");
                        count ++;
                        break;
                    case 3:
                        result = number1 / number2;
                        Console.WriteLine($"O resultado da Multiplicação :\n{number1}  / {number2} = {result}");
                        count ++;
                        break;
                    case 4:
                        opcao ++;
                        break;
                    default:
                        Console.WriteLine("opção invalida");
                        break;
                }
            }
        }
    }
}