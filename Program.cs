namespace fibcalc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello I will tell you your daily fiber intake based off your gender!");
Console.WriteLine("Please tell me if you are Male or Female?");
string answer = Console.ReadLine();
//string isGender = "Male";
bool isGender = answer.Equals("Male", StringComparison.OrdinalIgnoreCase);


if (isGender)
{
    Console.WriteLine("Your daily fiber intake is 32 Grams");
}
else
{
    Console.WriteLine("Your Daily fiber intake is 28 Grams");
}

Console.WriteLine("Enter how many grams of Fiber you have consumed today.");
string fiber = Console.ReadLine();
Console.WriteLine("Fiber: " + fiber);
    }
}
