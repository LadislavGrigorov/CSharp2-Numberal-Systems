using System;

class DecimalToHexadecimal
{
    static void ConvertToHex(int number)
    {
        int hexNumber = 0;
        string hexRepresent = "";
        while (number > 0)
        {
            hexNumber = number % 16;
            switch (hexNumber)
            {
                case 10:
                    hexRepresent = "A" + hexRepresent;
                    break;
                case 11:
                    hexRepresent = "B" + hexRepresent;
                    break;
                case 12:
                    hexRepresent = "C" + hexRepresent;
                    break;
                case 13:
                    hexRepresent = "D" + hexRepresent;
                    break;
                case 14:
                    hexRepresent = "E" + hexRepresent;
                    break;
                case 15:
                    hexRepresent = "F" + hexRepresent;
                    break;
                default:
                    hexRepresent = hexNumber + hexRepresent;
                    break;
            }
            number/=16;
        }
        Console.WriteLine(hexRepresent);
    }
    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());
        ConvertToHex(number);
    }
}
