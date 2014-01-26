using System;
using System.Text;

class HexToBinaryNumber
{
    static void ConvertToBinary(string hexNumber)
    {
        int decimalRepresentOfDigit = 0;
        
        StringBuilder binaryNumber = new StringBuilder();
        for (int i = 0; i < hexNumber.Length; i++)
        {
            string binaryDigit = "";
            if (hexNumber[i]>=48 && hexNumber[i]<=57)
            {
                decimalRepresentOfDigit = hexNumber[i] - '0';
            }
            else
            {
                decimalRepresentOfDigit = hexNumber[i] - '7';
            }
            int bit=0;
            while (decimalRepresentOfDigit > 0)         
            {
                bit = decimalRepresentOfDigit & 1;
                binaryDigit = bit + binaryDigit;
                decimalRepresentOfDigit= decimalRepresentOfDigit >> 1;
            }
            binaryNumber.Append(binaryDigit);
        }
        Console.WriteLine(binaryNumber);
    }
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal number(with capital letters - ABCDEF): ");
        string hexadecimalNumber = Console.ReadLine();
        ConvertToBinary(hexadecimalNumber);
    }
}
