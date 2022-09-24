using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("\tPress 1 for Addition");
                Console.WriteLine("\tPress 2 for Subtraction");
                Console.WriteLine("\tPress 3 for Multiplication");
                Console.WriteLine("\tPress 4 for Division");

                double angka1 = 0;
                double angka2 = 0;
                double result = 0;

                Console.Write("Enter number 1: ");
                angka1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                angka2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Pilih Opsi Perhitungan: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        result = angka1 + angka2;
                        Console.WriteLine($"The result is {result}");
                        break;
                    case "2":
                        result = angka1 - angka2;
                        Console.WriteLine($"The result is {result}");
                        break;
                    case "3":
                        result = angka1 * angka2;
                        Console.WriteLine($"The result is {result}");
                        break;
                    case "4":
                        result = angka1 / angka2;
                        Console.WriteLine($"The result is {result}");
                        break;
                    default:
                        Console.WriteLine("Tidak ada dalam Opsi");
                        break;
                }
            }  Console.ReadKey();
        }
    }
}