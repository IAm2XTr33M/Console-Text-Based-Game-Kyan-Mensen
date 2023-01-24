using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleGame
{
    class InputHandler
    {
        LineWriter lineWriter = new LineWriter(100);

        public void getEnter()
        {
            if (Console.ReadLine() == "")
            {
                Console.Clear();
                return;
            }
            else
            {
                lineWriter.writeLine("");
                lineWriter.writeColorLine("Your input was not recognized", ConsoleColor.DarkGray);
                getEnter();
            }
        }

        public void getInput(Room room, Player player,GhostManager ghostManager)
        {
            ConsoleKey keyPressed = Console.ReadKey().Key;

            string side = "n";
            int[] add = {0,0};

            switch (keyPressed)
            {
                case ConsoleKey.UpArrow:
                    side = "n";
                    add = new int[] { 1, 0 };
                    break;
                case ConsoleKey.DownArrow:
                    side = "s";
                    add = new int[] { -1, 0 };
                    break;
                case ConsoleKey.LeftArrow:
                    side = "w";
                    add = new int[] { 0, -1 };
                    break;
                case ConsoleKey.RightArrow:
                    side = "e";
                    add = new int[] { 0, 1 };
                    break;
                case ConsoleKey.Enter:
                    searchRoom();
                    break;
                case ConsoleKey.Spacebar:
                    if (ghostManager.checkGhost(player.pos))
                    {
                        ghostManager.removeGhost(player.pos);
                        if (player.pos[0] == 4 && player.pos[1] == 3)
                        {
                            lineWriter.writeColorLine("Get rid of all ghosts and go back to the entrance!", ConsoleColor.Green);
                            Thread.Sleep(1500);
                        }
                    }
                    break;
                default: 
                    return;
            }

            if(room.isDoor(side, player))
            {
                player.pos = new int[] { player.pos[0] + add[0], player.pos[1] + add[1] };
            }
            else if(keyPressed != ConsoleKey.Enter && keyPressed != ConsoleKey.Spacebar)
            {
                getInput(room, player, ghostManager);
            }


            void searchRoom()
            {
                if(player.pos[0]==0&& player.pos[1] == 2)
                {
                    player.collectedKeys.Add(new Key("r"));
                    lineWriter.writeColorLine("Congratulations you found the RED key.",ConsoleColor.Yellow);
                    Thread.Sleep(1000);
                }
                else if (player.pos[0] == 3 && player.pos[1] == 0)
                {
                    player.collectedKeys.Add(new Key("b"));
                    lineWriter.writeColorLine("Congratulations you found the BLUE key.", ConsoleColor.Yellow);
                    Thread.Sleep(1000);
                }
                else if (player.pos[0] == 2 && player.pos[1] == 4)
                {
                    player.collectedKeys.Add(new Key("y"));
                    lineWriter.writeColorLine("Congratulations you found the YELLOW key.", ConsoleColor.Yellow);
                    Thread.Sleep(1000);
                }
                else if (player.pos[0] == 1 && player.pos[1] == 4)
                {
                    player.collectedKeys.Add(new Key("p"));
                    lineWriter.writeColorLine("Congratulations you found the PURPLE key.", ConsoleColor.Yellow);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
