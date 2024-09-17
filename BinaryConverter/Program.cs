namespace BinaryConverter;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Do you want to play the game: ");
            string input = Console.ReadLine() ?? "no";
            if (input.ToLower() == "no")
            {
                continue;
            }
            Console.Write("Do you want a binary or a decimal number: ");
            string response = Console.ReadLine()!;
            switch (response.ToLower())
            {
                case "binary":
                {
                    int decimalNum = Random.Shared.Next(0, 16385);
                    Console.WriteLine($"Here is your binary number: {Convert.ToString(decimalNum, 2)}"); 
                    Thread.Sleep(10000);
                    Console.Write("Enter your answer: ");
                    string answer = Console.ReadLine()!;
                    if (answer == decimalNum.ToString())
                    {
                        Console.WriteLine($"Congratulations! You entered {decimalNum} which is the correct answer.");
                    }
                    else
                    {
                        Console.WriteLine($"You entered {answer} which is not the correct answer.");
                        Console.WriteLine($"The correct answer is: {decimalNum}");
                    }

                    Thread.Sleep(15000);
                    break;
                }
                case "decimal":
                    int value = Random.Shared.Next(0, 16385);
                    Console.WriteLine($"Here is your decimal number: {value}");
                    Thread.Sleep(10000);
                    Console.Write("Enter your answer: ");
                    string response2 = Console.ReadLine()!;
                    string binaryNum = Convert.ToString(value, 2);
                    if (response2 == binaryNum)
                    {
                        Console.WriteLine($"Congratulations! You entered {response2} which is the correct answer.");
                    }
                    else
                    {
                        Console.WriteLine($"You entered {response2} which is not the correct answer.");
                        Console.WriteLine($"The correct answer is: {binaryNum}");
                    }

                    Thread.Sleep(25000);
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }
        
    }
}