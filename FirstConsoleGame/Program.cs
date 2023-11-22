using Microsoft.VisualBasic;

namespace FirstConsoleGame
{
    internal class Program
    {
        //test

        public static int _roomWidth = 26;
        public static int _roomHeight = 17;
        public static int _newRoomVer = 5;
        public static int _newRoomHor = 24;
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
            bool room1 = true;

            //room 1
            while (room1)
            {
                playerVertical = StarterRoom(playerVertical, ref playerHorizontal, ref room1);
            }
            Console.Clear();
            Console.WriteLine("Room one complete");
        }

        private static int StarterRoom(int playerVertical, ref int playerHorizontal, ref bool room1)
        {
            Console.Clear();
            Console.WriteLine($"Vertical : {playerVertical}");
            Console.WriteLine($"Horizontal : {playerHorizontal}");
            update(playerVertical, playerHorizontal);
            var userInp = Console.ReadKey().Key;
            PlayerPositon(userInp, ref playerVertical, ref playerHorizontal);
            if (playerHorizontal == 26 && playerVertical == 5)
            {
                room1 = false;
            }

            Thread.Sleep(20);
            return playerVertical;
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
            for (int ver = 0; ver < _roomHeight; ver++)
            {
                for (int hor = 0; hor < _roomWidth; hor++)
                {
                    if (ver == playerVertical & hor == playerHorizontal)
                    {
                        Console.Write("M");
                        if (ver != _newRoomVer) continue;
                    }

                    if (ver == 0 || ver == _roomHeight - 1)
                    {
                        Console.Write("-");
                        continue;
                    }

                    if (ver == 5 && hor == _roomWidth - 1)
                    {
                        coridor();
                        continue;
                    }

                    if (hor == 0 || hor == _roomWidth - 1)
                    {
                        Console.Write("|");
                        continue;
                    }

                    if ((ver == 10 && hor == 13))
                    {
                        Console.Write("s");
                        Console.Write("\u2191");
                        hor++;
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