using System;

class Task1
{
    static void Main()
    {
        float[] arr = { 9.00f, 8.146f, 9.28f, 146f, 0.92f };

        Console.WriteLine("Integer values from the array:");
        
        foreach (float num in arr)
        {
            int intPart = 0;
            
            // Extract integer part by adding 1 until reaching or exceeding the number
            while (intPart + 1 <= num)
            {
                intPart++;
            }
            
            Console.Write(intPart + " ");
        }
    }
}
