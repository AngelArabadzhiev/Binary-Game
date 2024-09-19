namespace BinaryConverter;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Do you want to play the Binary Converter game? (yes/no): ");
            var input = Console.ReadLine() ?? "no";
            if (input.ToLower() == "no") break;
            if (input.ToLower() != "yes") Console.WriteLine("Invalid input. Try again with a yes or no.");
            Console.Write("Do you want to convert from a binary,decimal or a hexadecimal number? : ");
            var response = Console.ReadLine()!;
            switch (response.ToLower())
            {
                case "binary":
                {
                    Console.Write("Do you want to convert to a decimal or hexadecimal number: ");
                    var usrInputBin = Console.ReadLine()!;
                    switch (usrInputBin.ToLower())
                    {
                        case "hexadecimal":
                            var rndBinHex = Random.Shared.Next(0, 16385);
                            GenerateNum("binary", Convert.ToString(rndBinHex, 2));
                            var usrInputBinHex = Console.ReadLine()!;
                            CheckIfNumsEqual(Convert.ToString(rndBinHex, 16), usrInputBinHex);
                            break;
                        case "decimal":
                            var valueBin = Random.Shared.Next(0, 16385);
                            GenerateNum("binary", Convert.ToString(valueBin, 2));
                            var usrInputBinDec = Console.ReadLine()!;
                            CheckIfNumsEqual(valueBin.ToString(), usrInputBinDec);
                            Thread.Sleep(5000);
                            break;
                        default:
                            Console.WriteLine("Invalid input. Try again.");
                            break;
                    }

                    break;
                }
                case "decimal":
                    Console.Write("Do you want to convert to a hexadecimal or binary number: ");
                    var usrInputDec = Console.ReadLine();
                    switch (usrInputDec.ToLower())
                    {
                        case "binary":
                            var valueDecBin = Random.Shared.Next(0, 16385);
                            GenerateNum("decimal", valueDecBin.ToString());
                            var usrInputDecBin = Console.ReadLine()!;
                            CheckIfNumsEqual(Convert.ToString(valueDecBin, 2), usrInputDecBin);
                            break;
                        case "hexadecimal":
                            var rndDecHex = Random.Shared.Next(0, 16385);
                            GenerateNum("decimal", rndDecHex.ToString());
                            var usrInputHexDec = Console.ReadLine()!;
                            CheckIfNumsEqual(Convert.ToString(rndDecHex, 16), usrInputHexDec);
                            break;
                        default:
                            Console.WriteLine("Invalid input. Try again.");
                            break;
                    }
                    break;
                case "hexadecimal":
                    Console.Write("Do you want to convert to a decimal or binary number: ");
                    var usrInputHex = Console.ReadLine();
                    switch (usrInputHex.ToLower())
                    {
                        case "binary":
                            var rndBinHex = Random.Shared.Next(0, 16385); // Gives you a random number
                            GenerateNum("hexadecimal", Convert.ToString(rndBinHex, 16));
                            var usrInputHexBin = Console.ReadLine()!;
                            CheckIfNumsEqual(Convert.ToString(rndBinHex, 2), usrInputHexBin);
                            break;
                        case "decimal":
                            var rndDecHex = Random.Shared.Next(0, 16385); //Gives you a random number
                            GenerateNum("hexadecimal", Convert.ToString(rndDecHex, 16));
                            var usrInputHexDec = Console.ReadLine()!;
                            CheckIfNumsEqual(Convert.ToString(rndDecHex, 16), usrInputHexDec);
                            break;
                        default:
                            Console.WriteLine("Invalid input. Try again.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }
    }
    private static void CheckIfNumsEqual(string answer, string usrInput)
    {
        if (answer.ToLower() == usrInput.ToLower())
        {
            Console.WriteLine($"Congratulations! You entered {usrInput.ToUpper()} which is the correct answer.");
            Thread.Sleep(5000);
        }
        else
        {
            Console.WriteLine($"You entered {usrInput.ToUpper()} which is not the correct answer.");
            Console.WriteLine($"The correct answer is: {usrInput.ToUpper()}.");
            Thread.Sleep(15000);
        }
    }
    private static void GenerateNum(string type, string number)
    {
        Console.WriteLine($"Here is your {type} number: {number}.");
        Thread.Sleep(3000);
        Console.Write("Enter your answer: ");
    }
}