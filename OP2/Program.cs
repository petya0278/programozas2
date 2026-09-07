namespace OP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Üdvözlő";
            Console.Write("Irj be egy nevet");
            string name=Console.ReadLine();
            Console.WriteLine($"Szia {name}");


            Console.WriteLine("Irj be ket szamot!");

            Console.Write("Egyik szám: ");
            string num1=Console.ReadLine();

            Console.Write("Masodik szám: ");
            string num2 = Console.ReadLine();

            int szamol=int.Parse(num1)+int.Parse(num2);
            Console.WriteLine($"Eredmény: {szamol}");



            
        }
    }
}
