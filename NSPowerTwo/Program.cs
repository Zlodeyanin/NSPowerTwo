using System;

namespace NSPowerTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int startNumber = 2;
            int extent = 2;
            int extentCount = 0;
            int number = startNumber;
            int minRandomValue = 0;
            int maxRandomValue = 100;
            int randomNumber = random.Next(minRandomValue, maxRandomValue + 1);

            while (number <= randomNumber)
            {
                number *= extent;
                extentCount++;
            }

            Console.WriteLine($"Случайное число: {randomNumber}.\nСтепень двойки: {extentCount}.\nПревосходящее число: {number}.");
        }
    }
}