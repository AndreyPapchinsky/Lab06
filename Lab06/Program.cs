using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обработка данных массива.");

            Console.WriteLine("Введите количество элементов массива:");
            Operations.NewArray(out int elementsCount, out double[] newArray);

            Operations.Insert(elementsCount, newArray);

            Console.WriteLine($"Сумма всех элементов массива = {Operations.Sum(elementsCount, newArray)}");

            Console.WriteLine($"Cреднее значение массива = {Operations.Average(elementsCount, newArray)}");

            Operations.PlusMinus(elementsCount, newArray, out double plus, out double minus);
            Console.WriteLine($"Cумма положительных элементов = {plus} \nCумма отрицательных элементов = {minus}");

            Operations.EvenOdd(elementsCount, newArray, out double evenSum, out double oddSum);
            Console.WriteLine($"Cумма четных элементов = {evenSum} \nCумма нечетных элементов = {oddSum}");

            Operations.MiniMax(elementsCount, newArray, out int IndMax, out int IndMin);
            Console.WriteLine($"Максимальный индекс = {IndMax} \nМинимальный индекс = {IndMin}");

            Operations.ProdNum(elementsCount, newArray, out IndMax, out IndMin, out double ProdNum);
            Console.WriteLine($"Произведение элементов массива, расположенных между максимальным и минимальным элементами =  {ProdNum}");
        }


    }
}
