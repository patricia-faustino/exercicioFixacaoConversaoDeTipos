using System;

namespace exercicio1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite dois valores inteiros");
            int a, b, soma;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
             soma =a+b;
            Console.WriteLine("SOMA: "+soma);
        }
    }
}
