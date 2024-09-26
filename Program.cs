namespace fibcalc;

class Program
{
    static void Main(string[] args)
    { Console.WriteLine("Hello I will tell you your daily fiber intake based off your gender!");
    Console.WriteLine("Please TYPE M for Male or F for Female");
        //string answer = Console.ReadLine();
        //string isGender = "Male";
        //bool isGender = answer.Equals("Male", StringComparison.OrdinalIgnoreCase);
        var genderInput = Console.ReadLine()?.Trim().ToLower();
        var firstChar = genderInput[0];
        
        if (firstChar.Equals('m'))
        {
            Console.WriteLine("Your daily fiber intake is 32 Grams");
        }
        else if (firstChar.Equals('f'))
        {
            Console.WriteLine("Your Daily fiber intake is 28 Grams");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'M' or 'F' ");
            return;
        }

        Console.WriteLine("What is your fiber intake for the day?");




        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Please input a valid number");
            return;
        };

        double output = 0;
        double num2 = 32;
        double num3 = 28;
        switch (genderInput)
        {
            case "m":
                output = Subtract(num2, num1);
                if (num1 < 1 || num1 > 32)
                {
                    Console.WriteLine("Please enter a number from 1-32");
                    return;
                }

                if (output == 0)
                {
                    Console.WriteLine("Congratulations on hitting your daily fiber goal!!");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"You need {output} grams of fiber to finish your daily intake!");
                    Console.ReadLine();
                }
                break;

            case "f": output = Subtractf(num3, num1);
                if (num1 < 1 || num1 > 28)
                {
                    Console.WriteLine("Please enter a number from 1-28");
                    return;
                }

                if (output == 0)
                {
                    Console.WriteLine("Congratulations on hitting your daily fiber goal!!");
                     Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"You need {output} grams of fiber to finish your daily intake!");
                    Console.ReadLine();
                }
                
                break;
        }


    }
    public static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double Subtractf(double num1, double num3)
    {
        return num1 - num3;
    }
}
