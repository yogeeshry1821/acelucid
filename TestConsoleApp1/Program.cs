using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter triangle height: ");
        int n = int.Parse(Console.ReadLine());
        PrintTriangle(n);
    }

    static void PrintTriangle(int h)
    {
        for (int i = 1; i <= h; i++)
        {
            Console.Write(new string(' ', h - i));

            string stars = new string('*', 2 * i - 1);
            Console.Write(stars);

            Console.WriteLine();
        }
    }
}
