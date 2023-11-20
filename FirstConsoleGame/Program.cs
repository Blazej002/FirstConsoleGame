using Microsoft.VisualBasic;

namespace FirstConsoleGame
{
    internal class Program
    {
        private const int _roomWidth = 25;
        private const int _roomHeight = 15;
        static void Main(string[] args)
        {
            //Console.SetWindowSize(300, 200);
            int playerVertical = 1;
            int playerHorizontal = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Vertical : {playerVertical}");
                Console.WriteLine($"Horizontal : {playerHorizontal}");
                update(playerVertical, playerHorizontal);
                var userInp = Console.ReadKey().Key;
                PlayerPositon(userInp, ref playerVertical, ref playerHorizontal);
                Thread.Sleep(20);
            }
            
        }

        private static void PlayerPositon(ConsoleKey userInp,ref int playerVertical, ref int playerHorizontal)
        {
            switch (userInp)
            {
                case ConsoleKey.DownArrow:
                    if (playerVertical == (_roomHeight - 1)) break;
                    playerVertical++;
                    break;
                case ConsoleKey.UpArrow:
                    if (playerVertical == 0 ) break;
                    playerVertical--;
                    break;

                case ConsoleKey.LeftArrow:
                    if (playerHorizontal == 0) break;
                    playerHorizontal--;
                    break;
                case ConsoleKey.RightArrow:
                    if (playerHorizontal == (_roomWidth - 1)) break;
                    playerHorizontal++;
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }

        private static void update(int playerVertical, int playerHorizontal)
        {
            for (int i = 0; i < _roomHeight; i++)
            {
                for (int j = 0; j < _roomWidth; j++)
                {
                    if (i == playerVertical & j == playerHorizontal)
                    {
                        Console.Write("X");
                        continue;
                    }

                    Console.Write("@");
                }

                Console.WriteLine();
            }
        }
    }
}