using System;


namespace cs
{
     class Program
    {
        static void Main(string[] args)
        {
            string str1, str2, str3;

            Console.WriteLine("Введи число 1: ");
            str1 = Console.ReadLine();

            Console.WriteLine("Введи число 2:");
            str2 = Console.ReadLine();

            Console.WriteLine("Введи число 3:");
            str3 = Console.ReadLine();

            int a=Convert.ToInt32(str1);
            int b=Convert.ToInt32(str2);
            int c=Convert.ToInt32(str3);

            Console.WriteLine("Сумма: " + (a + b + c));
            Console.WriteLine("Произведение: " + (a * b * c));


        }
    }
}
