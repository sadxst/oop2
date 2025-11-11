using System;
using System.Threading;

class Program
{
    static int[] numbers = new int[10];
    static Random rand = new Random();

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(0, 26);
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine("\n");
        Thread t0 = new Thread(CountGreaterThan10);
        Thread t1 = new Thread(CountEvenNumbers);
        t0.Start();
        t1.Start();
        t0.Join();
        t1.Join();
        Console.WriteLine("\nРоботу потоків завершено.");
    }

    static void CountGreaterThan10()
    {
        int count = 0;
        foreach (int n in numbers)
        {
            if (n > 10) count++;
        }
        Console.WriteLine($"[T0] Кількість чисел більших за 10: {count}");
    }

    static void CountEvenNumbers()
    {
        int count = 0;
        foreach (int n in numbers)
        {
            if (n % 2 == 0) count++;
        }
        Console.WriteLine($"[T1] Кількість парних чисел: {count}");
    }
}