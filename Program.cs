using System;

namespace Calculator
{
    class Program 
    {
        static void Main (string[] args) 
        {
            Console.Clear();
            Console.Write("Bem Vindo(a) a nossa primeira calculadora em c#\nDeseja Iniciar ?\n1 - Iniciar\n2 - Encerrar Calculadora\n");
            int Opcao = int.Parse(Console.ReadLine());
            while(Opcao == 1)
            {           
                int count =0;
                Console.WriteLine("Digite o primeiro valor");
                float Number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                float Number2 = float.Parse(Console.ReadLine());

                Console.Write("Escolha uma opção abaixo:\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Encerrar Calculadora\n");
                int Acao = int.Parse(Console.ReadLine());


                float Result=0;

                switch (Acao){
                    case 1:
                        Result = Soma (Number1,Number2);
                        Console.WriteLine($"O resultado da Soma :\n{Number1}  + {Number2} = {Result}");
                        count ++;
                        break;
                    case 2:
                        Result = Subtracao (Number1,Number2);
                        Console.WriteLine($"O resultado da Soma :\n{Number1}  + {Number2} = {Result}");
                        count ++;
                        break;
                    case 3:
                        Result = Multiplicacao (Number1,Number2);
                        Console.WriteLine($"O resultado da Multiplicação :\n{Number1}  * {Number2} = {Result}");
                        count ++;
                        break;
                    case 4:
                        Result = Divisao (Number1,Number2);
                        Console.WriteLine($"O resultado da Multiplicação :\n{Number1}  / {Number2} = {Result}");
                        count ++;
                        break;
                    case 5:
                        Opcao ++;
                        break;
                    default:
                        Console.WriteLine("opção invalida");
                        break;
                }
            }
        }

        static float Soma (float number1, float number2)
        {
            return number1 + number2;                
        }

        static float Subtracao (float number1, float number2)
        {
            return number1 - number2;                
        }

        static float Multiplicacao (float number1, float number2)
        {
            return number1 * number2;
        }

        static float Divisao (float number1, float number2)
        {
            return number1 / number2;
        }
    }
}