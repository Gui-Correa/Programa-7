using System;

using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;

            Console.WriteLine("Digite seu nome: ");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite o nome da pessoa mais proxima de você : ");
            nome2 = Console.ReadLine();

            Console.WriteLine("Seu nome em letras maíusculas é: " + nome1.ToUpper());
            Console.WriteLine("Seu nome em letras maíusculas é: " + nome2.ToUpper());

            Console.WriteLine("Quantidade: " + nome1.Length + " caractere(s).", "ef3.Cinco");
            Console.WriteLine("Quantidade: " + nome2.Length + " caractere(s).", "ef3.Cinco");

            Console.WriteLine("Três primeiros caracteres são: " + nome1.Substring(0, 3));
            Console.WriteLine("Três primeiros caracteres são: " + nome2.Substring(0, 3));

            Console.ReadKey();
        }
    }
}