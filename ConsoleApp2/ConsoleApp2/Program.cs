using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите длину массива:");
        int length = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            numbers[i] = random.Next(1, 70);
        }

        int sum = 0;
        int count = 0;

        foreach (var number in numbers)
        {
            if (number % 2 == 1)
            {
                sum += number;
                count++;
            }
        }

        if (count > 0)
        {
            double average = (double)sum / count;
            Console.WriteLine($"Среднее арифметическое нечетных чисел: {average}");
        }
        else
        {
            Console.WriteLine("Массив состоит из четных чисел");
        }
    }
}