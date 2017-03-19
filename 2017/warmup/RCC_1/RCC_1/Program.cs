using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCC_1
{
    class Program
    {
        private static StringBuilder _sb = new StringBuilder();
        static void Main(string[] args)
        {
            var maxCount = int.Parse(Console.ReadLine());
            var tempPowers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var powers = new int[maxCount];
            var summ = 0;

            for (int i = 0; i < tempPowers.Length; i++)
            {
                var converted = int.Parse(tempPowers[i]);
                powers[i] = converted;
                summ += converted;
            }

            for (int i = 0; i < powers.Length; i++)
            {
                var current = powers[i];
                if (summ - current == current)
                {
                    PrintPowers(powers, i);
                    break;
                }
            }
        }

        private static void PrintPowers(int[] a, int lastIndex)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i != lastIndex)
                {
                    _sb.Append(a[i]);
                    _sb.Append(" ");
                }
            }

            _sb.Append(a[lastIndex]);

            Console.WriteLine(_sb.ToString());
        }
    }
}
