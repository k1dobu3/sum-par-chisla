using System;

namespace Chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1,sum = 0, kol=-1;
            Console.WriteLine("Введите вверхний потолок чисел:");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= N; i = i+=2 )
            {
                sum1 = i;
                sum += sum1;
                kol += 1;
            }
            Console.WriteLine($"Количество и сумма парных чисел в диапазоне от 1 до {N} равна: {kol} и {sum}");


        }
    }
}
