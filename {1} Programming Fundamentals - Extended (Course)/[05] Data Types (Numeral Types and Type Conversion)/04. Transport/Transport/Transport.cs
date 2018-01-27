using System;

namespace Transport
{
    public class Transport
    {
        public static void Main()
        {
            int Persons = int.Parse(Console.ReadLine());

            int carsCapacity = 4 + 8 + 12;
            decimal courses = Math.Ceiling((decimal)Persons / carsCapacity);

            Console.WriteLine(courses);
        }
    }
}
