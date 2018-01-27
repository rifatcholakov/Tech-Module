using System;

namespace Blank_Receipt
{
    public class BlankReceipt
    {
        public static void Main()
        {
            Header();
            Body();
            Footer();
        }
        public static void Header()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
        public static void Body()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        public static void Footer()
        {
            Console.WriteLine("------------------------------\n© SoftUni");
        }
    }
}
