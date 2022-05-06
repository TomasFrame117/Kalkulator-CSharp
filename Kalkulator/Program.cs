using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("skriv inn en verdi/tall: ");
            Double tall1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Skriv inn regnemetoden(+, -, /, *): ");
            string Opp = Console.ReadLine();

            Console.Write("skriv inn en verdi/tall: ");
            Double tall2 = Convert.ToDouble(Console.ReadLine());


            if(Opp == "+")
            {
                Console.WriteLine(tall1 + tall2);
            }
            else if (Opp == "-") 
            {
                Console.WriteLine(tall1 - tall2); 
            }
            else if(Opp == "/") 
            {
                Console.WriteLine(tall1 / tall2);
            }
            else if (Opp == "*")
            {
                Console.WriteLine(tall1 * tall2);
            }
        }
    }
}
