using System;

class Program
{
    static void Main()
    {
        Console.Write("Перше число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Друге цисло: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if ((number1 >= 1 && number1 <= 31) && (number2 >= 1 && number2 <= 12))
        {
            Console.WriteLine($"Число {number1} та {number2} можуть бути днем та мiсяцем.");
        }
        else ((number2 >= 1 && number2 <= 31) && (number1 >= 1 && number1 <= 12))
        {
            Console.WriteLine($"Число {number1} та {number2} можуть бути днем та мiсяцем.");
        }
        else
        {
            Console.WriteLine($"Число {number1} та {number2} не можуть бути днем та мiсяцем.");
        }
    }
}
