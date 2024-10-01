using System;

class Program
{
    static void PrintMenu()
    {
        Console.WriteLine("Please enter a valid option from below:");
        Console.WriteLine("1. Hello in French?");
        Console.WriteLine("2. Hello in Spanish?");
        Console.WriteLine("3. Hello in German?");
        Console.WriteLine("4. Hello in Italian?");
        Console.WriteLine("0. Exit application");
    }

    static int InputOption()
    {
        string input = Console.ReadLine();

        try
        {
            int option = int.Parse(input);
            return option;
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Input is not a valid number.");
            return -1;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Number entered is too small or too large.");
            return -1;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occured: {ex.Message}");
            return -1;
        }

    }

    static void Main(string[] args)
    {
        PrintMenu();

        int option = InputOption();

        switch (option)
        {
            case 1:
                Console.WriteLine("Hello in French: Bonjour");
                break;
            case 2:
                Console.WriteLine("Hello in Spanish: Hola");
                break;
            case 3:
                Console.WriteLine("Hello in German: Hallo");
                break;
            case 4:
                Console.WriteLine("Hello in Italian: Ciao");
                break;
            case 0:
                Console.WriteLine("Exiting application");
                break;
            default:
                Console.WriteLine("Error, Try again.");
                break;

        }
    }
}

