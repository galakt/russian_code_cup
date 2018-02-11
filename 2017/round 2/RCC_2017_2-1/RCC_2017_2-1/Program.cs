using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCC_2017_2_1
{
    class Program
    {
        private static readonly StringBuilder _sb = new StringBuilder();

        static void Main(string[] args)
        {
            var testCount = 1;//int.Parse(Console.ReadLine());

            for (int i = 0; i < testCount; i++)
            {
                var numbers = new string[] {"2", "3"};//Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                CalculateSeats(int.Parse(numbers[0]), int.Parse(numbers[1]));
            }

            var s = _sb.ToString();//Console.WriteLine(_sb.ToString());
        }

        private static void CalculateSeats(int n, int m)
        {
            var max = n * m;
            var d = new Dictionary<int,int>();
            var d2 = new Dictionary<int,int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    var a = i + j;

                    if (d.ContainsKey(a))
                    {
                        d[a] = d[a] + 1;
                    }
                    else
                    {
                        d.Add(a, 1);
                    }
                }
            }

            //d[0] = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    _sb.Append(max - CalcPrevCount(d, i, j));
                    _sb.Append(" ");
                }
                _sb.AppendLine();
            }
        }

        private static int CalcPrevCount(Dictionary<int, int> d, int i, int j)
        {
            var a = i + j;
            var res = 0;

            while (a > -1)
            {
                res += d[a];
                a--;
            }

            return res;
        }
    }
}
