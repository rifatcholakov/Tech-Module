using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Main()
        {
            int firstOperand = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secoundOperand = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{firstOperand} {operation} {secoundOperand} = {firstOperand + secoundOperand}");
                    break;
                case '-':
                    Console.WriteLine($"{firstOperand} {operation} {secoundOperand} = {firstOperand - secoundOperand}");
                    break;
                case '*':
                    Console.WriteLine($"{firstOperand} {operation} {secoundOperand} = {firstOperand * secoundOperand}");
                    break;
                case '/':
                    Console.WriteLine($"{firstOperand} {operation} {secoundOperand} = {firstOperand / secoundOperand}");
                    break;
            }
        }
    }
}
