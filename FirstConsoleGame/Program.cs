using Microsoft.VisualBasic;

namespace FirstConsoleGame
{
    internal class Program
    {
        //test

        public static int _roomWidth = 26;
        public static int _roomHeight = 17;
        
        //Is only used to specify where the coridor to new room is
        public static int _newRoomVer = 5;
        public static int _newRoomHor = 24;
    

        static void Main(string[] args)
        {
            var player = new Player();
            //Console.SetWindowSize(300, 200);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            int playerVertical = 2;
            int playerHorizontal = 2;
            playerVertical = 3;
            bool room1 = true;

            //room 1
            while (room1)
            {   
                //Draws the player and the room, Clears console and takes player input to find positon
                StarterRoom(ref playerVertical, ref playerHorizontal, ref room1, ref player);
            }

            Console.Clear();
            Console.WriteLine("Room one complete");
        }

        private static void StarterRoom(ref int playerVertical, ref int playerHorizontal, ref bool room1, ref Player player)
        {
            Console.Clear();
            //draws info like positon and player info like hp
            info(playerVertical, playerHorizontal, ref player);

            //The draw player positon and room part of code
            update(playerVertical, playerHorizontal);

            // Finds in player position
            var userInp = Console.ReadKey().Key;
            PlayerPositon(userInp, ref playerVertical, ref playerHorizontal);

            //Checks if player has entered coridor
            if (playerHorizontal == 26 && playerVertical == 5)
            {
                room1 = false;
            }

            Thread.Sleep(20);
        }

        private static void info(int playerVertical, int playerHorizontal,ref Player player)
        {
            Console.WriteLine($"Vertical : {playerVertical}");
            Console.WriteLine($"Horizontal : {playerHorizontal}");
            Console.WriteLine($"Hp: {player.hp}| | Has weapon: {player.hasWeapon} | | Dmg: {player.dmg}");
        }

        private static void PlayerPositon(ConsoleKey userInp, ref int playerVertical, ref int playerHorizontal)
        {
            switch (userInp)
            {
                //Nothing special here, takes player input and adds or subtracts values from player positon
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
            //I think i should make the rooms thru objects
            //I need to rework this whole part.
            for (int ver = 0; ver < _roomHeight; ver++)
            {
                for (int hor = 0; hor < _roomWidth; hor++)
                {
                    // Player being drawn
                    if (ver == playerVertical & hor == playerHorizontal) { Console.Write("M"); if (ver != _newRoomVer) continue; }

                    //Coridor hard coded.
                    if (ver == 5 && hor == _roomWidth - 1) { coridor(); continue; }

                    //Walls
                    if (ver == 0 || ver == _roomHeight - 1) { Console.Write("-"); continue; }
                    if (hor == 0 || hor == _roomWidth - 1) { Console.Write("|"); continue; }
                    
                    //Weapon, i need a way to pick it up
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