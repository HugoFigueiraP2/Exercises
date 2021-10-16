using System;

class Program
{
    static void Main(string[] args)
    {
        int [] sum = new int [4];
        Console.WriteLine("Enter 4 numbers to calculate the average\n If you don´t mind of course ;D");
        for( int i = 0; i < sum.Length; i++)
        {
            sum[i] = Convert.ToInt32(Console.ReadLine());
        }
        int result = sum[0] + sum[1] + sum[2] + sum[3];
        result = result / 4;

        Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", sum[0], sum[1]
        ,sum[2], sum[3], result);
    }
}