using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int N = int.Parse(Console.ReadLine());

        int count = 0, num = 1;

        while (count < N)
        {
            num++;
            if (IsPrime(num))
                count++;
        }

        Console.WriteLine($"The {N}th prime number is: {num}");
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
