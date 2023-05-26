using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        bool flag = false;
        foreach (string word in words)
        {
            if (IsValidDate(word))
            {
                Console.WriteLine("Found valid date: " + word);
                flag = true;
            }
        }
        if(!flag){
            Console.WriteLine("No valid date found.");
        }
    }

    static bool IsValidDate(string word)
    {
        if (word.Length == 8)
        {
            string monthStr = word.Substring(0, 2);
            string dayStr = word.Substring(2, 2);
            string yearStr = word.Substring(4);

            if (int.TryParse(monthStr, out int month) &&
                int.TryParse(dayStr, out int day) &&
                int.TryParse(yearStr, out int year))
            {
                if (month >= 1 && month <= 12)
                {
                    int maxDays = DateTime.DaysInMonth(year, month);
                    if (day >= 1 && day <= maxDays)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}
