using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Számológép");

        Console.Write("Írd be az első számot: ");
        double szam1;

        while (!double.TryParse(Console.ReadLine(), out szam1))
        {
            Console.Write("Hibás adat! Csak számot írj be: ");
        }

        Console.Write("Írd be a műveletet (+, -, *, /): ");
        string muvelet = Console.ReadLine();

        while (muvelet != "+" && muvelet != "-" &&
               muvelet != "*" && muvelet != "/")
        {
            Console.Write("Hibás művelet! Írd be: +, -, * vagy /: ");
            muvelet = Console.ReadLine();
        }

        Console.Write("Írd be a második számot: ");
        double szam2;

        while (!double.TryParse(Console.ReadLine(), out szam2))
        {
            Console.Write("Hibás adat! Csak számot írj be: ");
        }

        double eredmeny = 0;

        
        if (muvelet == "+")
        {
            eredmeny = szam1 + szam2;
        }
        else if (muvelet == "-")
        {
            eredmeny = szam1 - szam2;
        }
        else if (muvelet == "*")
        {
            eredmeny = szam1 * szam2;
        }
        else if (muvelet == "/")
        {
            if (szam2 == 0)
            {
                Console.WriteLine("Hiba! Nullával nem lehet osztani.");
                return;
            }

            eredmeny = szam1 / szam2;
        }

        Console.WriteLine("Eredmény: " + eredmeny);
    }
}

