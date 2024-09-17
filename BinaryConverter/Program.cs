namespace BinaryConverter;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Do you want to play the game: ");
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
                    var usrInputBin = Console.ReadLine();
                    switch (usrInputBin.ToLower())
                    {
                        case "hexadecimal":
                            var rndBinHex = Random.Shared.Next(0, 16385);
                            var binaryNum = Convert.ToString(rndBinHex, 2);
                            var hexNum = Convert.ToString(rndBinHex, 16);
                            Console.WriteLine($"Here is your binary number: {binaryNum}.");
                            Thread.Sleep(5000);
                            Console.Write("Enter your answer: ");
                            var response2 = Console.ReadLine()!;
                            if (response2.ToLower() == hexNum.ToLower())
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
                            var valueBin = Random.Shared.Next(0, 16385);
                            Console.WriteLine($"Here is your binary number: {Convert.ToString(valueBin, 2)}");
                            Thread.Sleep(5000);
                            Console.Write("Enter your answer: ");
                            var answer = Console.ReadLine()!;
                            if (answer == valueBin.ToString())
                            {
                                Console.WriteLine(
                                    $"Congratulations! You entered {valueBin} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {answer} which is not the correct answer.");
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
                    var usrInputDec = Console.ReadLine();
                    switch (usrInputDec.ToLower())
                    {
                        case "binary":
                            var valueDecBin = Random.Shared.Next(0, 16385);
                            Console.WriteLine($"Here is your decimal number: {valueDecBin}");
                            Thread.Sleep(10000);
                            Console.Write("Enter your answer: ");
                            var response2 = Console.ReadLine()!;
                            var binaryNum = Convert.ToString(valueDecBin, 2);
                            if (response2 == binaryNum)
                            {
                                Console.WriteLine(
                                    $"Congratulations! You entered {response2} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {response2} which is not the correct answer.");
                                Console.WriteLine($"The correct answer is: {binaryNum}");
                                Thread.Sleep(15000);
                            }

                            break;
                        case "hexadecimal":
                            var rndDecHex = Random.Shared.Next(0, 16385);
                            Console.WriteLine($"Here is your decimal number: {rndDecHex}");
                            Console.Write("Enter your answer: ");
                            var answerHexDec = Console.ReadLine()!;
                            string answHex = $"{rndDecHex:X}";
                            if (answerHexDec.ToLower() == answHex.ToLower())
                            {
                                Console.WriteLine(
                                    $"Congratulations! You entered {answerHexDec.ToUpper()} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {answerHexDec.ToUpper()} which is not the correct answer.");
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
                    var usrInputHex = Console.ReadLine();
                    switch (usrInputHex.ToLower())
                    {
                        case "binary":
                            var rndBinHex = Random.Shared.Next(0, 16385);
                            var hexNum = Convert.ToString(rndBinHex, 16);
                            var binaryString = string.Join(string.Empty,
                                hexNum.Select(
                                    c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                                )
                            );
                            Console.WriteLine($"Here is your hexadecimal number: {rndBinHex:X}");
                            Thread.Sleep(5000);
                            Console.Write("Enter your answer: ");
                            var answerHexBin = Console.ReadLine()!;
                            if (answerHexBin == binaryString)
                            {
                                Console.WriteLine(
                                    $"Congratulations! You entered {answerHexBin} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {answerHexBin} which is not the correct answer.");
                                Console.WriteLine($"The correct answer is: {binaryString}");
                                Thread.Sleep(15000);
                            }

                            break;
                        case "decimal":
                            var rndDecHex = Random.Shared.Next(0, 16385);
                            Console.WriteLine($"Here is your hexadecimal number: {rndDecHex:X}.");
                            Thread.Sleep(5000);
                            Console.Write("Enter your answer: ");
                            var answerHexDec = Console.ReadLine()!;
                            if (answerHexDec == rndDecHex.ToString())
                            {
                                Console.WriteLine(
                                    $"Congratulations! You entered {answerHexDec} which is the correct answer.");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine($"You entered {answerHexDec} which is not the correct answer.");
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