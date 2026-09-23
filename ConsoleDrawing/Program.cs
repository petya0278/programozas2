namespace ConsoleDrawing;

    //█░▒▓   ╔╗═║╝╚

    using System;
internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            // 1. Keret
            for (int x = 0; x < width; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("╔");
                Console.SetCursorPosition(x, height - 1);
                Console.Write("╗");
            }
            for (int y = 0; y < height; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("╝");
                Console.SetCursorPosition(width - 1, y);
                Console.Write("╚");
            }
            // Kezdő 
            int cursorX = 1;
            int cursorY = 1;
            char karakter = '#';
            ConsoleColor szin = ConsoleColor.White;
            ConsoleColor hatter = ConsoleColor.Black;
            bool capsLock = false;
            Console.SetCursorPosition(cursorX, cursorY);
            // 2.
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // ESC 
                if (key.Key == ConsoleKey.Escape)
                    break;
                // 2. Kurzor 
                if (key.Key == ConsoleKey.UpArrow && cursorY > 1)
                    cursorY--;
                if (key.Key == ConsoleKey.DownArrow && cursorY < height - 2)
                    cursorY++;
                if (key.Key == ConsoleKey.LeftArrow && cursorX > 1)
                    cursorX--;
                if (key.Key == ConsoleKey.RightArrow && cursorX < width - 2)
                    cursorX++;
                // 3. Space 
                if (key.Key == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(cursorX, cursorY);
                    Console.ForegroundColor = szin;
                    Console.BackgroundColor = hatter;
                    Console.Write(karakter);
                }
                // 4
                if (key.Key == ConsoleKey.F1)
                    karakter = '#';
                if (key.Key == ConsoleKey.F2)
                    karakter = '*';
                if (key.Key == ConsoleKey.F3)
                    karakter = '+';
                if (key.Key == ConsoleKey.F4)
                    karakter = '@';
                // 5. 
                if (key.Key == ConsoleKey.D1)
                    szin = ConsoleColor.White;
                if (key.Key == ConsoleKey.D2)
                    szin = ConsoleColor.Red;
                if (key.Key == ConsoleKey.D3)
                    szin = ConsoleColor.Green;
                if (key.Key == ConsoleKey.D4)
                    szin = ConsoleColor.Blue;
                // 6. 
                if (key.Key == ConsoleKey.Subtract)
                {
                    if (szin == ConsoleColor.White)
                        szin = ConsoleColor.Gray;
                    else if (szin == ConsoleColor.Red)
                        szin = ConsoleColor.DarkRed;
                    else if (szin == ConsoleColor.Green)
                        szin = ConsoleColor.DarkGreen;
                    else if (szin == ConsoleColor.Blue)
                        szin = ConsoleColor.DarkBlue;
                }
                if (key.Key == ConsoleKey.Add)
                {
                    if (szin == ConsoleColor.Gray)
                        szin = ConsoleColor.White;
                    else if (szin == ConsoleColor.DarkRed)
                        szin = ConsoleColor.Red;
                    else if (szin == ConsoleColor.DarkGreen)
                        szin = ConsoleColor.Green;
                    else if (szin == ConsoleColor.DarkBlue)
                        szin = ConsoleColor.Blue;
                }
                // 7. 
                if (key.Key == ConsoleKey.B)
                {
                    hatter = ConsoleColor.DarkBlue;
                }
                // 8. 
                if (key.Key == ConsoleKey.Delete ||
                    key.Key == ConsoleKey.Backspace)
                {
                    Console.SetCursorPosition(cursorX, cursorY);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
                
                // Kurzor megjelenítése
                Console.SetCursorPosition(cursorX, cursorY);
                if (capsLock)
                {
                    Console.Write("_");
                }
                Console.SetCursorPosition(cursorX, cursorY);
            }
            Console.ResetColor();
            Console.Clear();
        }
    }
