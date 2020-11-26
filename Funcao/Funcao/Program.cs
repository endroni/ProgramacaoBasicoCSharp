using System;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números: ");
            double v1 = double.Parse(Console.ReadLine());
            double v2 = double.Parse(Console.ReadLine());
            double res = Multiplicar(v1, v2);
            Console.WriteLine(res);
        }

        private static double Multiplicar(double v1, double v2)
        {
            double res = v1 * v2;
            return res;
        }
    }
}


