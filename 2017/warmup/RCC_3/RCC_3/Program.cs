using System;

namespace RCC_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // g, r и b 
            var tempCounts = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var greenModels = new IntExt[int.Parse(tempCounts[0])];
            var redModels = new IntExt[int.Parse(tempCounts[1])];
            var blueModels = new IntExt[int.Parse(tempCounts[2])];

            PopulateArrays(greenModels, Console.ReadLine());
            PopulateArrays(redModels, Console.ReadLine());
            PopulateArrays(blueModels, Console.ReadLine());

            Array.Sort(redModels);

            var counter = 0;
            var lastRedItemCounter = 0;

            for (int r = 0; r < redModels.Length; r++)
            {
                var currentR = redModels[r];

                if (r > 0)
                {
                    if (redModels[r].Value == redModels[r - 1].Value)
                    {
                        counter += lastRedItemCounter;
                        continue;
                    }
                    else
                    {
                        lastRedItemCounter = 0;
                    }
                }

                for (int g = 0; g < greenModels.Length; g++)
                {
                    var currentG = greenModels[g];
                    if (currentR.Value == currentG.Value)
                    {
                        continue;
                    }

                    if (currentR.FirstDigit != currentG.LastDigit)
                    {
                        continue;
                    }

                    for (int b = 0; b < blueModels.Length; b++)
                    {
                        var currentB = blueModels[b];
                        if (currentB.Value == currentR.Value
                            || currentB.Value == currentG.Value)
                        {
                            continue;
                        }

                        if (currentR.LastDigit != currentB.FirstDigit)
                        {
                            continue;
                        }

                        lastRedItemCounter++;
                    }
                }

                counter += lastRedItemCounter;
            }

            Console.WriteLine(counter);
        }

        private static void PopulateArrays(IntExt[] a, string str)
        {
            var temp = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < temp.Length; i++)
            {
                a[i] = ConvertToIntExt(temp[i]);
            }
        }

        private static IntExt ConvertToIntExt(string s)
        {
            var Value = int.Parse(s);
            var firstDigit = 0;
            var lastDigit = 0;

            if (Value < 10)
            {
                return new IntExt(Value, Value, Value);
            }
            else if (Value < 100)
            {
                firstDigit = Value / 10;
            }
            else if (Value < 1000)
                firstDigit = Value / 100;
            else if (Value < 10000)
                firstDigit = Value / 1000;
            else if (Value < 100000)
                firstDigit = Value / 10000;
            else if (Value < 1000000)
                firstDigit = Value / 100000;
            else if (Value < 10000000)
                firstDigit = Value / 1000000;
            else if (Value < 100000000)
                firstDigit = Value / 10000000;
            else if (Value < 1000000000)
                firstDigit = Value / 100000000;
            else
                firstDigit = Value / 1000000000;

            lastDigit = Value % 10;

            return new IntExt(Value, firstDigit, lastDigit);
        }
    }

    public struct IntExt : IComparable<IntExt>
    {
        private int _value;

        private int _firstDigit;

        private int _lastDigit;

        public IntExt(int value, int firstDigit, int lastDigit)
        {
            _value = value;
            _lastDigit = lastDigit;
            _firstDigit = firstDigit;
        }

        public int Value { get { return _value; }}

        public int FirstDigit { get { return _firstDigit; } }

        public int LastDigit { get { return _lastDigit; } }

        public int CompareTo(IntExt other)
        {
            if (_value < other.Value) return -1;
            if (_value > other.Value) return 1;
            return 0;
        }
    }
}
