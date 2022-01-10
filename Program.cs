using System;

namespace cs
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         // byte number = 255; "8 бит"
    //         // short number = 15000; "16 бит"
    //         // int number = 5251; // " 32 бит"
    //         // long number = NewMethod(); "64 бит"

    //         float number = 15000.05f;

    //         // double number = 5.15d;
    //         string word = "Переменная: ";
    //         // char symbol = 'sFsa';

    //         // bool is_happy = false;

    //         Console.WriteLine(word + number + "!");

    //     }

    // }
    class IntegerMethod
    {
        static void Main()
        {
            int num_1 = 0, num_2 = 0;

            num_1 = Convert.ToInt32(Console.ReadLine());
            num_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First: " + num_1 + ". Second: " + num_2);
        }
    }

}