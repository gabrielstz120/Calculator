using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------");
            Console.WriteLine("Qual opção deseja?");
            short res = short.Parse(Console.ReadLine());
            
            switch(res) {
                case 1 : Soma (); break;
                case 2 : Subtracao (); break;
                case 3 : Divisao (); break;
                case 4 : Multiplicacao(); break;
                case 5 : System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            double N1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double N2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            var soma = N1 + N2;
            Console.WriteLine("O resultado da soma é: "+ soma);
            Console.ReadKey();
            Menu();
        
        }
    
        static void Subtracao(){
            Console.Clear();

            Console.WriteLine("Primeiro numero: ");
            double N1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            double N2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            var subtracao = N1 - N2;
            Console.WriteLine("O resultado da subtração é: " + subtracao);
            Console.ReadKey();
            Menu();

        }

        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Primeiro numero: ");
            double N1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            double N2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            var divisao = N1 / N2;
            Console.WriteLine("O resultado da divisão é: " + divisao);
            Console.ReadKey();
            Menu();
        }
    
        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro numero:");
            double N1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            double N2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            var divisao = N1 * N2;
            Console.WriteLine("O resultado da Divisão é: " + divisao);
            Console.ReadKey();
            Menu();

        }

    }

        

}