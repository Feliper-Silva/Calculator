using System;

namespace Calculator
{
    class Program 
    {
        static void Main (string[] args) 
        {
            int Opcao = Menu();
            while(Opcao == 1)
            {           
                Console.Write("Escolha uma opção abaixo:\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Encerrar Calculadora\n");
                int Acao = int.Parse(Console.ReadLine());

                switch (Acao){
                    case 1:
                         Soma ();
                        break;
                    case 2:
                        Subtracao ();
                        break;
                    case 3:
                        Multiplicacao ();
                        break;
                    case 4:
                        Divisao ();
                        break;
                    case 5:
                        Opcao ++;
                        break;
                    default:
                        Menu();
                        break;
                }
            }
        }

        static int Menu ()
        {
            Console.Clear();
            Console.Write("Bem Vindo(a) a nossa primeira calculadora em c#\nDeseja Iniciar ?\n1 - Iniciar\n2 - Encerrar Calculadora\n----------------\n");
            return int.Parse(Console.ReadLine());
        }

        static void Soma ()
        {
            Console.WriteLine("Digite o primeiro valor");
            float Number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float Number2 = float.Parse(Console.ReadLine());
            float Result = Number1 + Number2;
            Console.WriteLine($"O resultado da Soma é:\n{Number1}  + {Number2} = {Result}");
             
        }

        static void Subtracao ()
        {
            Console.WriteLine("Digite o primeiro valor");
            float Number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float Number2 = float.Parse(Console.ReadLine());
            float Result = Number1 - Number2;
            Console.WriteLine($"O resultado da Subtração é:\n{Number1}  + {Number2} = {Result}\n");
           
        }

        static void Multiplicacao ()
        {
            Console.WriteLine("Digite o primeiro valor");
            float Number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float Number2 = float.Parse(Console.ReadLine());
            float Result = Number1 * Number2;
            Console.WriteLine($"O resultado da Multiplicação :\n{Number1}  * {Number2} = {Result}\n");
        }

        static void Divisao ()
        {
            Console.WriteLine("Digite o primeiro valor");
            float Number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float Number2 = float.Parse(Console.ReadLine());
            float Result = Number1 / Number2;
            Console.WriteLine($"O resultado da Divisão :\n{Number1}  / {Number2} = {Result}\n");

        }
    }
}