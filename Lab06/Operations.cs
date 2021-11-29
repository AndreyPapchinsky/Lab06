using System;

namespace Lab06
{
    internal class Operations
    {
        public static void NewArray(out int elementsCount, out double[] newArray)
        {
            elementsCount = int.Parse(Console.ReadLine());
            newArray = new double[elementsCount];
        }

        public static double Average(int elementsCount, double[] newArray)
        {
            return Operations.Sum(elementsCount, newArray) / elementsCount;
        }

        public static void EvenOdd(int elementsCount, double[] newArray, out double evenSum, out double oddSum)
        {
            evenSum = new();
            oddSum = new();
            for (int i = 0; i < elementsCount; i++)
            {
                if (i % 2 == 0)
                    evenSum += newArray[i];
                else
                    oddSum += +newArray[i];
            }
        }

        public static void Insert(int elementsCount, double[] newArray)
        {
            Console.WriteLine($"Заполните массив [{elementsCount}]");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine($"Ведите значение для [{i}]");
                newArray[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine($"Индекс [{i}] : " + newArray[i]);
            }
        }

        public static void MiniMax(int elementsCount, double[] newArray, out int IndMax, out int IndMin)
        {
            double Max = newArray[0];
            double Min = newArray[0];
            IndMax = new();
            IndMin = new();
            for (int i = 0; i < elementsCount; i++)
            {
                if (newArray[i] > Max)
                {
                    Max = newArray[i];
                    IndMax = i;
                }

                if (newArray[i] < Min)
                {
                    Min = newArray[i];
                    IndMin = i;
                }
            }
        }

        public static void PlusMinus(int elementsCount, double[] newArray, out double plus, out double minus)
        {
            plus = 0;
            minus = 0;
            for (int i = 0; i < elementsCount; i++)
            {
                if (newArray[i] > 0)
                {
                    plus += newArray[i];
                }
                else if (newArray[i] < 0)
                {
                    minus += newArray[i];
                }
            }
        }

        public static void ProdNum(int elementsCount, double[] newArray, out int IndMax, out int IndMin, out double ProdNum)
        {
            ProdNum = 1;
            MiniMax(elementsCount, newArray, out IndMax, out IndMin);
            int begin = Math.Min(IndMin, IndMax) + 1;
            int end = Math.Max(IndMin, IndMax);

            if (end - begin > 0)
            {
                for (int i = begin; i < end; i++)
                {
                    ProdNum *= newArray[i];
                }
            }
            else
            {
                ProdNum = 0;
            }
        }

        public static double Sum(int elementsCount, double[] newArray)
        {
            double Sum = 0;
            for (int i = 0; i < elementsCount; i++)
            {
                Sum += newArray[i];
            }

            return Sum;
        }
    }
}