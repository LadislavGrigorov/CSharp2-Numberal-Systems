using System;

class ConvertToAnyNumberalSystem
{
    static int PowerOfNumber(int number, int power)
    {
        int product = 1;
        for (int i = 0; i < power; i++)
        {
            product *= number;
        }
        return product;
    }
    static int ConvertToDecimal(string number, int baseInput)
    {
        int powerCounter = 0;
        int decimalNumber = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (number[i] >= 48 && number[i] <= 57)
            {
                decimalNumber += (number[i] - '0') * PowerOfNumber(baseInput, powerCounter);
                powerCounter++;
            }
            else
            {
                decimalNumber += (number[i] - '7') * PowerOfNumber(baseInput, powerCounter);
                powerCounter++;
            }
        }
        return decimalNumber;
    }
    static string ConvertToRandomNumSystem(int decimalNumber, int baseOutput)
    {
        string numberString = string.Empty;
        int currentDigit = 0;
        while (decimalNumber > 0)
        {
            currentDigit = decimalNumber % baseOutput;
            switch (currentDigit)
            {
                case 10:
                    numberString = 'A' + numberString;
                    break;
                case 11:
                    numberString = 'B' + numberString;
                    break;
                case 12:
                    numberString = 'C' + numberString;
                    break;
                case 13:
                    numberString = 'D' + numberString;
                    break;
                case 14:
                    numberString = 'E' + numberString;
                    break;
                case 15:
                    numberString = 'F' + numberString;
                    break;
                default:
                    numberString = currentDigit + numberString;
                    break;
            }
            decimalNumber /= baseOutput;
        }
        return numberString;
    }
    static void Main()
    {
        Console.Write("Enter number(if above decimal base with capital letters - ABCDEF): ");
        string numberInput = Console.ReadLine();
        Console.Write("Enter base of number: ");
        int baseInput = int.Parse(Console.ReadLine());
        Console.Write("Enter base output: ");
        int baseOutput = int.Parse(Console.ReadLine());
        int decimalNumber = ConvertToDecimal(numberInput, baseInput);
        Console.WriteLine(ConvertToRandomNumSystem(decimalNumber, baseOutput));
    }
}
