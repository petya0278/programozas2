using System.ComponentModel.Design;
//eldontes tetele


Console.WriteLine("Irj be ket szamot!");

Console.Write("Egyik szám: ");
decimal num1 = decimal.Parse(Console.ReadLine());

Console.Write("Masodik szám: ");
decimal num2 = decimal.Parse(Console.ReadLine());

Console.Write("Művelet (+,-,*,/):");
string muvelet = Console.ReadLine();

decimal szam = 0;

if (muvelet == "+")
{
    szam = num1 + num2;
}
else if (muvelet == "-")
{
    szam = num1 - num2;
}
else if (muvelet == "*")
{
    szam = num1 * num2;
}
else if (muvelet == "/" && num2 != 0)
{
    szam = num1 % num2;
}
else
{
    Console.WriteLine("Hibás muvelet");
    
}

Console.WriteLine($"Eredmény {szam}");
