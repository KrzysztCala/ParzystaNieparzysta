using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParzystaNieparzysta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM OKREŚLANIA PARZYSTOŚCI/NIEPARZYSTOŚCI LICZBY\n");
            Console.WriteLine("Naciśnij w dowolnym momencie Ctrl-C, aby zakończyć.\n\n");
            do
            {
                Console.Write("\nWpisz liczbę: ");
                try
                {
                    int number1 = GetIntInput();
                    if(number1 % 2 == 0)
                    {
                        Console.WriteLine("Wprowadzona liczba jest parzysta.");
                    }
                    else
                    {
                        Console.WriteLine("Wprowadzona liczba jest nieparzysta.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Spróbuj ponownie!");
                    continue;  
                }
            } while (true);


        }

        private static int GetIntInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                throw new Exception("Podana wartość jest nieprawidłowa.");
            }
            return number;
        }

    }



}
