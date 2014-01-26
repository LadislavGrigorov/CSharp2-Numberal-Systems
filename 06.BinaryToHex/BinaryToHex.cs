using System;
using System.Text;

class BinaryToHex
{
    static int PowerOfNumber(int number, int power) //find power of number because math.pow works slower
    {
            int product = 1;
            for (int i = 0; i < power; i++)
            {
                product *= number;
            }
            return product;
    }
    static void ConvertToHex(ref string binaryNumber)
    {
        int remainder = binaryNumber.Length % 4;
        if (remainder != 0)
        {
            binaryNumber = new string('0', 4 - remainder) + binaryNumber;
        }
        StringBuilder hexNumber = new StringBuilder();
        for (int i = 0; i < binaryNumber.Length; i += 4)  
        {
            int powerCounter = 0;
            int sum = 0;
            for (int j = i + 3; j >= i; j--)                    
            {

                if (binaryNumber[j] == '1')
                {
                    sum += PowerOfNumber(2, powerCounter);
                }
                powerCounter++;
            }
            switch (sum)
            {
                case 10:
                    hexNumber.Append("A");
                    break;
                case 11:
                    hexNumber.Append("B");
                    break;
                case 12:
                    hexNumber.Append("C");
                    break;
                case 13:
                    hexNumber.Append("D");
                    break;
                case 14:
                    hexNumber.Append("E");
                    break;
                case 15:
                    hexNumber.Append("F");
                    break;
                default:
                    hexNumber.Append(sum);
                    break;
            }
        }
        Console.WriteLine(hexNumber);
    }
    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        ConvertToHex(ref binaryNumber);
    }
}
