namespace ConsoleDrawing
{
    internal class Program
    //█░▒▓   ╔╗═║╝╚

    {
        static void DrawBorder()
        {
            //1.

            Console.Write("╔");

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("═");

            }
           
            
            static void Main(string[] args)
            {
                DrawBorder();
                Console.CursorVisible = true;
                int width= Console.WindowWidth;
                int height= Console.WindowHeight;

                for (int i = 0; i < width; i++) { 
                Console.SetCursorPosition(i, 0);
                    Console.Write('═');
                }
            }
        }
    }
}
