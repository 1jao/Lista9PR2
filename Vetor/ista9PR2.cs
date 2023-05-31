using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vetor
{
    internal class Program
    {

        public static void Exercicio1()
        {

            int[] vet = new int[6];
            vet[0] = 7;
            vet[1] = 26;
            int[] vet2;
            Console.WriteLine("qual o tamanho?");
            int t = int.Parse(Console.ReadLine());
            float soma = 0;
            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(0, 10);
                soma = soma + vet2[i];

            }
            for (int i = 0; i < t; i++)
            {
                Console.Write("[{0}]\t", i);
            }
            Console.WriteLine();
            for (int i = 0; i < t; i++)
            {
                Console.Write(vet2[i] + "\t");

            }
            Console.WriteLine("resultado média aritmédica: " + soma / t);

        }

        public static void Exercicio2()
        {

            int[] vett = new int[6];
            vett[0] = 7;
            vett[1] = 26;
            int[] vett2;
            Console.WriteLine("qual o tamanho?");
            int tt = int.Parse(Console.ReadLine());


            vett2 = new int[tt];
            Random rando = new Random();

            for (int i = 0; i < tt; i++)
            {
                vett2[i] = rando.Next(0, 10);

            }
            for (int i = 0; i < tt; i++)
            {
                Console.Write("[{0}]\t", i);
            }
            Console.WriteLine();
            for (int i = 0; i < tt; i++)
            {
                Console.Write(vett2[i] + "\t");

            }
        }
        public static void Exercicio3()
        {
            Console.WriteLine();
        }

        public static void Exercicio4()
        {


        }
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("          menu           ");
                Console.WriteLine("para sair digite 0");
                Console.WriteLine("para executar o exercicio 1 - digite 1");
                Console.WriteLine("para executar o exercicio 2 - digite 2");
                Console.WriteLine("para executar o exercicio 3 - digite 3");
                Console.WriteLine("para executar o exercicio 4 - digite 4");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("obrigado por usar");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    default:
                        Console.WriteLine("o numero não é um exercicio valido");
                        break;
                }

            } while (true);


        }
    }
}



