using System;
class Program
{
    public static string choice;

    public static string venugopal()
    {
        Console.WriteLine("Please choose an option: ");
        Console.WriteLine("A - Call DemoQuestion3 ");
        Console.WriteLine("B - Call DemoQuestion4 ");
        Console.WriteLine("C - Call DemoQuestion5 ");
        Console.WriteLine("X - Exit ");
        Console.WriteLine("Enter your choice: ");
        choice = Console.ReadLine();
        // choice.ToLowerCase();
        return choice;
    }
    public static void DemoQuestion3()
    {
        Console.WriteLine("DemoQuestion3 has been called.");
    }
    public static void DemoQuestion4()
    {
        Console.WriteLine("DemoQuestion4 has been called.");
    }
    public static void DemoQuestion5()
    {
        Console.WriteLine("DemoQuestion5 has been called.");
    }

    public static void Main(string[] args)
    {
        string input;
        while (true)
        {
            input = venugopal();
            switch (input.ToUpper())
            {
                case "A":
                    DemoQuestion3();
                    break;
                case "B":
                    DemoQuestion4();
                    break;
                case "C":
                    DemoQuestion5();
                    break;
                case "X":
                    Console.WriteLine("Ends");
                    return;
                default:
                    Console.WriteLine("invalid choice please try again");
                    break;
            }
        }
    }

}