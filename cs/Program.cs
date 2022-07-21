using System;


namespace cs
{
     class Program
    {
        static void Main(string[] args)
        {
            string str, str2;
            
            Console.WriteLine("Введи число 1: ");
            str = Console.ReadLine();
            double a = Convert.ToInt64(str);

            Console.WriteLine("Введи число 2: ");
            str2 = Console.ReadLine();
            double b = Convert.ToInt64(str2);

            double result = (a + b) / 2;

            Console.WriteLine(result);

        }
    }
}
