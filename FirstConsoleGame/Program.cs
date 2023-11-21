using Microsoft.VisualBasic;

namespace FirstConsoleGame
{
    internal class Program
    {
         
        static int _roomWidth = 26;
        static int _roomHeight = 17;
        static int _newRoomVer = 5;
        static int _newRoomHor = 24;
        public int playerVertical = 1;
        public int playerHorizontal = 1;

        static void Main(string[] args)
        {
            //Console.SetWindowSize(300, 200);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            int playerVertical = 1;
            int playerHorizontal = 1;
            playerVertical = 6;


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

        private static void PlayerPositon(ConsoleKey userInp, ref int playerVertical, ref int playerHorizontal)
        {
            switch (userInp)
            {
                case ConsoleKey.DownArrow:
                    if (playerVertical == (_roomHeight - 2)) break;
                    playerVertical++;
                    break;
                case ConsoleKey.UpArrow:
                    if (playerVertical == 1) break;
                    playerVertical--;
                    break;

                case ConsoleKey.LeftArrow:
                    if (playerHorizontal == 1) break;
                    playerHorizontal--;
                    break;
                case ConsoleKey.RightArrow:
                    if (playerHorizontal == (_roomWidth - 2) & playerVertical != _newRoomVer) break;
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
                        Console.Write("M");
                        if (i != _newRoomVer) continue;

                    }

                    if (i == 0 || i == _roomHeight - 1)
                    {
                        Console.Write("-");
                        continue;
                    }

                    if (i == 5 && j == _roomWidth - 1)
                    {
                        coridor();
                        continue;
                    }

                    if (j == 0 || j == _roomWidth - 1)
                    {
                        Console.Write("|");
                        continue;
                    }

                   
                    
                    Console.Write(".");
                    
                }

                Console.WriteLine();
            }
        }

        private static void coridor()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(".");
            }
        }

        private static void newRoom()
        {
        }
    }
}