using System.ComponentModel.Design;

namespace OP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Irj be ket szamot!");

            Console.Write("Egyik szám: ");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Masodik szám: ");
            decimal num2 =decimal.Parse(Console.ReadLine());

            Console.Write("Művelet (+,-,*,/):");
            string muvelet=Console.ReadLine();

           decimal szam = 0;

            if (muvelet == "+")
            {
                szam = num1 + num2;
            }
            else if (muvelet == "-") 
            {
                szam = num1 - num2;
            }
            else if(muvelet == "*")
            {
                szam = num1 * num2;
            }
            else if (muvelet == "/")
            {
                if (num2==0)
                    Console.WriteLine("Nullával nem osztunk");
                    
                szam = num1 / num2;
                return;
            }
            else
                    {
                Console.WriteLine("Hibás muvelet");
                return;
            }

            Console.WriteLine($"Eredmény {szam}");
        }
    }
}
