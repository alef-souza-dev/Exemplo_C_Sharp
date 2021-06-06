using System;
using _01_ESTRUTURADOPROGRAMA.Exemplos;

namespace _01_ESTRUTURADOPROGRAMA
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            Console.WriteLine(1);
            s.Empilha(10);
            Console.WriteLine(10);
            s.Empilha(100);
            Console.WriteLine(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}
