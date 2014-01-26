using System;

class HexadecimalToDecimal
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
    static void ConvertToDecimal(string hexNumber)
    {
        int sum = 0;
        int powerCounter=0;
        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            if ((hexNumber[i]>=48) && (hexNumber[i]<=57))
            {
                sum += (hexNumber[i] - '0') * (PowerOfNumber(16, powerCounter));
                powerCounter++;
            }
            else
            {
                sum += (hexNumber[i] - '7') * (PowerOfNumber(16, powerCounter)); //- '7' because 7 is the 55th symbol of ascii table, 'A' is 65
                powerCounter++;                                                  // so 'A' will be equal to 10, B to 11 and so...
            }
        }
        Console.WriteLine(sum);
    }
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal number(with capital letters - ABCDEF): ");
        string hexadecimalNumber = Console.ReadLine();
        ConvertToDecimal(hexadecimalNumber);
    }
}
