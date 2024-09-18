namespace BinaryConverter;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Do you want to play the game: ");
            string input = Console.ReadLine() ?? "no";
            if (input.ToLower() == "no") break;
            if (input.ToLower() != "yes") Console.WriteLine("Invalid input. Try again with a yes or no.");
            Console.Write("Do you want to convert from a binary,decimal or a hexadecimal number? : ");
            string response = Console.ReadLine()!;
            switch (response.ToLower())
            {
                case "binary":
                {
                    Console.Write("Do you want to convert to a decimal or hexadecimal number: ");
                    string usrInputBin = Console.ReadLine();
                    switch (usrInputBin.ToLower())
                    {
                        case "hexadecimal":
                            int rndBinHex = Random.Shared.Next(0, 16385);
                            string binaryNum = Convert.ToString(rndBinHex, 2); //Converts to the binary system
                            string hexNum = Convert.ToString(rndBinHex, 16); //Converts to the hexadecimal system
                            Console.WriteLine($"Here is your binary number: {binaryNum}.");
                            Thread.Sleep(5000);
                            Console.Write("Enter your answer: ");
                            string usrInputBinHex = Console.ReadLine()!;
                            if (usrInputBinHex.ToLower() == hexNum.ToLower())
                            {
                                Console.WriteLine(
                                    $"Congratulations! You entered {hexNum.ToUpper()} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {response.ToUpper()} which is not the correct answer.");
                                Console.WriteLine($"The correct answer is: {hexNum.ToUpper()}.");
                                Thread.Sleep(15000);
                            }
                            break;
                        case "decimal":
                            int valueBin = Random.Shared.Next(0, 16385);
                            Console.WriteLine($"Here is your binary number: {Convert.ToString(valueBin, 2)}"); //Gives you a random binary number
                            Thread.Sleep(5000);
                            Console.Write("Enter your answer: ");
                            string usrInputBinDec = Console.ReadLine()!;
                            if (usrInputBinDec == valueBin.ToString())
                            {
                                Console.WriteLine(
                                    $"Congratulations! You entered {valueBin} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {usrInputBinDec} which is not the correct answer.");
                                Console.WriteLine($"The correct answer is: {valueBin}");
                                Thread.Sleep(15000);
                            }
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
                    string usrInputDec = Console.ReadLine();
                    switch (usrInputDec.ToLower())
                    {
                        case "binary":
                            int valueDecBin = Random.Shared.Next(0, 16385);
                            Console.WriteLine($"Here is your decimal number: {valueDecBin}"); //Gives you a random decimal number
                            Thread.Sleep(10000);
                            Console.Write("Enter your answer: ");
                            string usrInputDecBin = Console.ReadLine()!;
                            string binaryNum = Convert.ToString(valueDecBin, 2); //Coverts that random number to the binary system
                            if (usrInputDecBin == binaryNum)
                            {
                                Console.WriteLine($"Congratulations! You entered {usrInputDecBin} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {usrInputDecBin} which is not the correct answer.");
                                Console.WriteLine($"The correct answer is: {binaryNum}");
                                Thread.Sleep(15000);
                            }
                            break;
                        case "hexadecimal":
                            int rndDecHex = Random.Shared.Next(0, 16385);
                            Console.WriteLine($"Here is your decimal number: {rndDecHex}"); //Gives you a random decimal number
                            Console.Write("Enter your answer: ");
                            string usrInputHexDec = Console.ReadLine()!;
                            string answHex = $"{rndDecHex:X}"; //Coverts that number to the hexadecimal system
                            if (usrInputHexDec.ToLower() == answHex.ToLower())
                            {
                                Console.WriteLine(
                                    $"Congratulations! You entered {usrInputHexDec.ToUpper()} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {usrInputHexDec.ToUpper()} which is not the correct answer.");
                                Console.WriteLine($"The correct answer is: {answHex.ToUpper()}");
                                Thread.Sleep(15000);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input. Try again.");
                            break;
                    }
                    break;
                case "hexadecimal":
                    Console.Write("Do you want to convert to a decimal or binary number: ");
                    string usrInputHex = Console.ReadLine();
                    switch (usrInputHex.ToLower())
                    {
                        case "binary":
                            int rndBinHex = Random.Shared.Next(0, 16385); // Gives you a random number
                            string hexNum = Convert.ToString(rndBinHex, 16);
                            string binaryHexString = string.Join(string.Empty,
                                hexNum.Select(
                                    c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                                )
                            ); //Converts the random number from binary to hexadecimal
                            Console.WriteLine($"Here is your hexadecimal number: {rndBinHex:X}");
                            Thread.Sleep(5000);
                            Console.Write("Enter your answer: ");
                            string usrInputHexBin = Console.ReadLine()!;
                            if (usrInputHexBin == binaryHexString)
                            {
                                Console.WriteLine(
                                    $"Congratulations! You entered {usrInputHexBin} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {usrInputHexBin} which is not the correct answer.");
                                Console.WriteLine($"The correct answer is: {binaryHexString}");
                                Thread.Sleep(15000);
                            }
                            break;
                        case "decimal":
                            int rndDecHex = Random.Shared.Next(0, 16385); //Gives you a random number
                            Console.WriteLine($"Here is your hexadecimal number: {rndDecHex:X}."); // Convert that number to the hexadecimal system
                            Thread.Sleep(5000);
                            Console.Write("Enter your answer: ");
                            string usrInputHexDec = Console.ReadLine()!;
                            if (usrInputHexDec == rndDecHex.ToString())
                            {
                                Console.WriteLine(
                                    $"Congratulations! You entered {usrInputHexDec} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {usrInputHexDec} which is not the correct answer.");
                                Console.WriteLine($"The correct answer is: {rndDecHex:X}");
                                Thread.Sleep(15000);
                            }
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
}