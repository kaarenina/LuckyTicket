using System;

namespace Lucky_Ticket
{
    class Program
    {
         public static int sumDigits(int number)
        {
            if (number < 10) return number;
            return number % 10 + sumDigits(number / 10);       
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter ticket number. \nEmpty string - exit");
            while (true)
            {
                string stringNumber = Console.ReadLine();

                if (String.IsNullOrEmpty(stringNumber)) break;

                if (stringNumber.Length < 4 || stringNumber.Length > 8) break;

                if (stringNumber.Length % 2 != 0)
                    stringNumber = "0" + stringNumber;

                int number1 = Convert.ToInt32(stringNumber.Substring(0,stringNumber.Length/2));
                int number2 = Convert.ToInt32(stringNumber.Substring(stringNumber.Length / 2));

                if (sumDigits(number1) == sumDigits(number2))
                    Console.WriteLine("Lucky ticket !");
                else Console.WriteLine("Awful ticket !");      
            }
        }
    }
}
