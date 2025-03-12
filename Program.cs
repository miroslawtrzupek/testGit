using System.Diagnostics.CodeAnalysis;

namespace testGit
{
    internal class Program
    {
        static double suma(double liczba1, double liczba2)
        {
            return liczba1 + liczba2;
        }
        static void Main(string[] args)
        {
            double liczba1 = 5;
            double liczba2 = 44;
            Console.WriteLine($"{liczba1} + {liczba2} = {suma(liczba1, liczba2)}");
        }
    }
}
