using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleGame
{
    class Texthandler
    {
        LineWriter lineWriter = new LineWriter(80);

        public Player player;
        public GhostManager ghostManager;
        public RoomManager roomManager;

        public Texthandler(int i, Player p, GhostManager g, RoomManager r)
        {
            this.lineWriter.writeSpeed = i;
            this.player = p;
            this.ghostManager = g;
            this.roomManager = r;
        }

        public void text(int i)
        {
            switch (i)
            {
                case 1:

                    lineWriter.write("Welcome to ");
                    lineWriter.writeInvertedLine("Ghosthunter");
                    lineWriter.writeLine("Please type your name.");
                    lineWriter.writeLine("----------------------");
                    
                    break;
                case 2:

                    Console.Clear();
                    lineWriter.write("Welcome ");
                    lineWriter.writeColor(player.name, ConsoleColor.Green);
                    lineWriter.writeLine(" ,We are excited to have you here.");
                    lineWriter.writeLine("");
                    lineWriter.writeColorLine("press ENTER to start", ConsoleColor.DarkGray);
                    
                    break;
                case 3:

                    Console.Clear();

                    lineWriter.writeSpeed = 90;

                    lineWriter.write(@"--------------------------------------------------------
|              ");
                    lineWriter.writeColor(@"from: randomClient@email.com", ConsoleColor.Green);
                    lineWriter.write(@"            |
|                ");
                    lineWriter.writeColor(@"to: Ghost@hunter.com ", ConsoleColor.Yellow);
                    lineWriter.write(@"                 |
|               subject: ");
                    lineWriter.writeSpeed = 50;
                    Console.ForegroundColor = ConsoleColor.Red;
                    lineWriter.writeRemove(@"Haunted house!!", 20);
                    Console.ForegroundColor = ConsoleColor.White;
                    lineWriter.writeSpeed = 90;
                    lineWriter.write(@"Home inspection");
                    lineWriter.write(@"               |
|======================================================|
|                  Dear ghosthunter.                   |
|                  I need your help.                   |
|                                                      |
| For the last few months strange occurances have been |
|            happening all arround my house            |
|        I'm sure it must be a ghost (or multiple).    |
| They keep locking doors and hiding keys, be carefull |
| Please explore my house and make sure that no ghosts |
|                remain once you are done.             |
|            When all Ghosts are gone you can go       |
|                    back to the Entrance.             |
|                                                      |
|          Arrows = move up/down/left/right            |
|                Enter = search room                   |
|                Space = attack ghost                  |
|                                                      |
|        Use your ghostDetector to detect ghosts       |
|                                                      |
|                      Thank you                       |
|                    -RandomClient-                    |
--------------------------------------------------------");
                    lineWriter.writeLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    lineWriter.writeRemove(@"Good Luck", 20);
                    Console.ForegroundColor = ConsoleColor.White;
                    lineWriter.writeSpeed = 80;
                    lineWriter.writeColorLine("press ENTER to continue", ConsoleColor.DarkGray);
                    
                    break;
                case 4:

                    Console.Clear();
                    lineWriter.write("GhostDetector: ");
                    lineWriter.writeInverted("      ");
                    this.lineWriter.writeSpeed = 50;



                    if (ghostManager.checkGhost(player.pos))
                    {
                        lineWriter.writeColorInverted("   ",ConsoleColor.Red);
                        lineWriter.writeColorLine(" : Ghost Detected!!!", ConsoleColor.Red);
                    }
                    else
                    {
                        lineWriter.writeColorInvertedLine("   ", ConsoleColor.Green);
                    }

                    this.lineWriter.writeSpeed = 80;
                    lineWriter.writeInvertedLine(ghostManager.ghosts.Count.ToString() + "/10  ghosts remaining.");
                    Console.WriteLine("----------------------------------");

                    lineWriter.writeLine("RoomName: "+roomManager.getCurrentRoom(player.pos).name);
                    this.lineWriter.writeSpeed = 99;
                    lineWriter.writeLine(roomManager.getCurrentRoom(player.pos).desc);

                    break;
                case 5:

                    Console.Clear();
                    lineWriter.writeColor("CONGRATULATIONS ", ConsoleColor.Yellow);
                    lineWriter.writeColorLine(player.name, ConsoleColor.Green);

                    lineWriter.writeColorLine("You Succesfully got rid of all of the Ghosts!" , ConsoleColor.Yellow);
                    lineWriter.writeColorLine("Take some rest, because I have more houses for you to go too!" , ConsoleColor.Yellow);

                    lineWriter.writeLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    lineWriter.writeRemove("GOODNIGHT!!!", 100);
                    Console.ForegroundColor = ConsoleColor.White;
                    lineWriter.writeLine("Sleep well :D");

                    lineWriter.writeLine("");
                    lineWriter.writeColorLine("Press ENTER to quit the game", ConsoleColor.DarkGray);

                    break;
                default:
                    break;
            }
        }

    }
}
