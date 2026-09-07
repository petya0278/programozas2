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
        }
    }
}
