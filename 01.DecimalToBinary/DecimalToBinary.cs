using System;

class DecimalToBinary
{
    static void ConvertToBinary(int number)
    {
        string binaryRepresent = "";
        int firstBit = 0;
        while (number > 0)
        {
            firstBit = number & 1;
            binaryRepresent = firstBit + binaryRepresent;
            number = number >> 1;
        }
        Console.WriteLine(binaryRepresent);
    }
    static void Main()
    {
        Console.WriteLine("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        ConvertToBinary(number);
    }
}
