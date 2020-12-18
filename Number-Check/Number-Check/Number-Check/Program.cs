using System;

namespace Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                double defaultNumber = 0.05;
                Console.Write("Syötä numero: ");
                double checkNumber = double.Parse(Console.ReadLine());

                if (checkNumber < defaultNumber)
                {
                    Console.WriteLine($"Luku {checkNumber} on pienempi kuin {defaultNumber} \n");
                }
                else
                {
                    Console.WriteLine($"Luku {checkNumber} on suurempi kuin {defaultNumber} \n");
                }

                while (true)
                {
                    Console.Write("Uudestaan? [Y/N]");
                    string answer = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    if (answer == "Y")
                        break;
                    if (answer == "N")
                        return;
                }
            }
        }
    }
}
