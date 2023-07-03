using System.Threading;
using System;

class NovelTextPrinter
{
    private bool waitForSpace;

    public NovelTextPrinter()
    {
        waitForSpace = true;
    }

    public void PrintLine(string line)
    {
        Console.WriteLine();

        if (waitForSpace)
        {
            foreach (char c in line)
            {
                Console.Write(c);
                Thread.Sleep(5);
            }
        }
        else
        {
            Console.WriteLine(line);
        }
    }

    public bool ChooseOption(string option1, string option2)
    {
        Console.WriteLine();
        Console.WriteLine("Выберите вариант:");
        Console.WriteLine($"1. {option1}");
        Console.WriteLine($"2. {option2}");

        while (true)
        {
            ConsoleKeyInfo input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                return true;
            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                return false;
            }
        }
    }

    public void Wait()
    {
        Console.WriteLine();

        while (true)
        {
            ConsoleKeyInfo input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.Spacebar)
            {
                break;
            }
        }
    }
}