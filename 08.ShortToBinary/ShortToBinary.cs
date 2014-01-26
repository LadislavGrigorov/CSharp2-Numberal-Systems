using System;

class ShortToBinary
{
    static void ConvertPositveToBin(short number)
    {
        int bit = 0;
        string binaryString = string.Empty;
        while (number>0)
        {
            bit = number & 1;
            binaryString = bit + binaryString;
            number /= 2;
        }
        binaryString = binaryString.PadLeft(16, '0');
        Console.WriteLine(binaryString);
    }
    static void ConvertNegativeToBin(short number)
    {
        int bit = 0;
        string binaryString = string.Empty;
        number = (short)(-(32768 - number));
        while (number > 0)
        {
            bit = number & 1;
            binaryString = bit + binaryString;
            number /= 2;
        }
        binaryString = binaryString.PadLeft(15, '0').PadLeft(16,'1');
        Console.WriteLine(binaryString);
    }
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        if (number>=0)
        {
            ConvertPositveToBin(number);
        }
        else
        {
            ConvertNegativeToBin(number);
        }
    }
}
