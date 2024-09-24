namespace fibcalc;

class Program
{
    static void Main(string[] args)
    { Console.WriteLine("Hello I will tell you your daily fiber intake based off your gender!");
    Console.WriteLine("Please tell me if you are Male or Female?");
        //string answer = Console.ReadLine();
        //string isGender = "Male";
        //bool isGender = answer.Equals("Male", StringComparison.OrdinalIgnoreCase);
        string genderInput = Console.ReadLine()?.Trim().ToLower();

        //if (isGender
        if (genderInput == "male")
        {
            Console.WriteLine("Your daily fiber intake is 32 Grams");
        }
        else if (genderInput == "female")
        {
            Console.WriteLine("Your Daily fiber intake is 28 Grams");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'male' or 'female' ");
        }


       
    }
}
//new line for test
