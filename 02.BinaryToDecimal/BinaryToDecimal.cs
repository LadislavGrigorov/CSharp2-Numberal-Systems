using System;

class BinaryToDecimal
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
    static void ConvertToDecimal(string binaryNumber)
    {
        int sum = 0;
        int powerCounter = 0;
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            if (binaryNumber[i]=='1')
            {
                sum += PowerOfNumber(2, powerCounter);
            }
            powerCounter++;
        }
        Console.WriteLine(sum);
    }
    static void Main()
    {
        Console.WriteLine("Enter binary number: ");
        string binaryNumber = Console.ReadLine();
        ConvertToDecimal(binaryNumber);
    }
}
