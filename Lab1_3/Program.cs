using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            double S;
            Console.Write("N = ");
            N = Convert.ToInt32(Console.ReadLine());
            S = 0;
            i = N;
            while (i <= 22)
{
                S += Math.Sqrt(Math.Pow(i, 2) + Math.Pow(N, 2)) / i;
                i++;
            }
            Console.WriteLine($"{Math.Round(S, 2)}");
            S = 0;
            i = N;
            do
            {
                S += Math.Sqrt(Math.Pow(i, 2) + Math.Pow(N, 2)) / i;
                i++;
            } while (i <= 22);
            Console.WriteLine($"{Math.Round(S, 2)}");
            S = 0;
            for (i = N; i <= 22; i++)
{
                S += Math.Sqrt(Math.Pow(i, 2) + Math.Pow(N, 2)) / i;
            }
            Console.WriteLine($"{Math.Round(S, 2)}");
            S = 0;
            for (i = 22; i >= N; i--)

{
                S += Math.Sqrt(Math.Pow(i, 2) + Math.Pow(N, 2)) / i;
            }
            Console.WriteLine($"{Math.Round(S, 2)}");
            Console.ReadKey();
        }
    }
}
