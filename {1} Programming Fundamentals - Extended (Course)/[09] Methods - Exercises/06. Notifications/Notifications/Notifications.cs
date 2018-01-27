using System;

namespace Notifications
{
    public class Notifications
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string firstResult = Console.ReadLine();
            string firstOperation = Console.ReadLine();
            string message = Console.ReadLine();

            string secoundResult = Console.ReadLine();
            string secoundOperation = Console.ReadLine();
            int code = int.Parse(Console.ReadLine());

            //switch (firstResult)
            //{
            //    case "success":
            //        ShowSuccess(firstOperation, message);
            //        break;
            //    case "error":
            //        ShowError(secoundOperation, code);
            //        break;
            //}

            //switch (secoundResult)
            //{
            //    case "success":
            //        ShowSuccess(secoundOperation, message);
            //        break;
            //    case "error":
            //        ShowError(secoundOperation, code);
            //        break;
            //}

            if (firstOperation.Equals("success"))
            {
                ShowSuccess(firstOperation, message);
            }
            else if (firstOperation.Equals("error"))
            {
                ShowError(firstResult, code);
            }

            if (secoundOperation.Equals("error"))
            {
                ShowSuccess(secoundOperation, message);
            }
            else if (firstOperation.Equals("error"))
            {
                ShowError(secoundResult, code);
            }
        }
    public static void ShowSuccess(string operation, string message)
    {
        Console.WriteLine($"Successfully executed {operation}.");
        Console.WriteLine("==============================");
        Console.WriteLine($"Message: {message}.");
    }
    public static void ShowError(string operation, int code)
    {
        Console.WriteLine($"Error: Failed to execute {operation}.");
        Console.WriteLine("==============================");
        Console.WriteLine($"Error Code: {code}.");
        Console.WriteLine($"Reason: {reason}.");
    }
}
}
