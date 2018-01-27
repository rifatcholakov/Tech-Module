using System;

namespace Variable_in_Hexadecimal_Format
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            string hexFormat = Console.ReadLine();

            int intFormat = Convert.ToInt32(hexFormat, 16);

            Console.WriteLine(intFormat);
        }
    }
}
