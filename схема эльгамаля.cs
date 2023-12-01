using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace эльгамаль
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Введите модуль P");
                int P = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите закрытый ключ");
                double x = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите сообщение М");
                double M = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число K");
                int K = Convert.ToInt32(Console.ReadLine());
                int f = 0;
                int g = 0;
                int l = 0;
                double c = 0;
                List<int> collection = new List<int>();

                for (int i = 1; i < P; i++)
                {
                    bool vsaimnoprostoe = true;
                    for (int j = i; j > 1; j--)
                    {

                        if (P % j == 0 && i % j == 0)
                        {
                            vsaimnoprostoe = false;
                        }

                    }
                    if (vsaimnoprostoe)
                    {
                        f++;
                    }
                }
                for (int j = 2; j < P; j++)
                {
                    double o = Math.Pow(j, f);
                    if (o % P == 1)
                    {
                        collection.Add(j);
                    }
                }

                foreach (int a in collection)
                {
                    for (int d = 1; d < f; d++)
                    {
                        double v = Math.Pow(a, d);
                        if (v % P != 1)
                        {
                            l++;
                        }
                        if (l == f - 1)
                        {
                            g = a;
                        }

                    }
                }
                if (x > 1 & x < P)
                {
                    c = Math.Pow(g, x);
                }
                double y = c % P;
                Console.WriteLine($"Открытые ключи: {P}, {g}, {y}");
                Console.WriteLine($"Закрытый ключ: {x}");
                if (M < P & K > 1 & (P - 1) > K)
                {
                    double a1 = Math.Pow(g, K);
                    double a = a1 % P;
                    double b1 = Math.Pow(y, K) * M;
                    double b = b1 % P;
                    Console.WriteLine($"Шифр: a:{a}, b:{b}");
                    double h = P - 1 - x;
                    double M1 = b * Math.Pow(a, h)%P;
                    Console.WriteLine($"Расшифровка{M}={M1}");
                    if (M == M1)
                    {
                        Console.WriteLine("Алгоритм был реализован правильно");
                    }
                    else
                    {
                        Console.WriteLine("Алгоритм был реализован неправильно");
                    }
                }
            }
        }
    }
}
