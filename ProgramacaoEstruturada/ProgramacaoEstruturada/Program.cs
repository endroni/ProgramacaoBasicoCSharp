using System;

namespace ProgramacaoEstruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int aux;
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
