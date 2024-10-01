using System;

class Program
{
    //Q1
    static void PrintMenu()
    {
        Console.WriteLine("Please enter a valid option from below:");
        Console.WriteLine("1. Hello in French?");
        Console.WriteLine("2. Hello in Spanish?");
        Console.WriteLine("3. Hello in German?");
        Console.WriteLine("4. Hello in Italian?");
        Console.WriteLine("0. Exit application");
    }


    static void Main(string[] args)
    {
        PrintMenu();

        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.WriteLine("Hello in French: Bonjour");
                break;
            case "2":
                Console.WriteLine("Hello in Spanish: Hola");
                break;
            case "3":
                Console.WriteLine("Hello in German: Hallo");
                break;
            case "4":
                Console.WriteLine("Hello in Italian: Ciao");
                break;
            case "0":
                Console.WriteLine("Exiting application");
                break;
            default:
                Console.WriteLine("Error. Try again");
                break;

        }
    }
}

